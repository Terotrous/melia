﻿using System.Collections.Generic;
using System;
using System.Linq;
using g3;
using Melia.Shared.Data.Database;
using Melia.Shared.World;
using Yggdrasil.Geometry;
using Yggdrasil.Util;

namespace Melia.Zone.World.Maps
{
	/// <summary>
	/// Represents a map's ground.
	/// </summary>
	public class Ground
	{
		private const float RayOriginHeight = 20000;

		private GroundData _data;
		private DMesh3 _mesh;
		private DMeshAABBTree3 _spatial;
		private Polygon2d[] _cells;

		/// <summary>
		/// Loads the ground data.
		/// </summary>
		/// <param name="data"></param>
		public void Load(GroundData data)
		{
			_data = data;

			this.LoadGroundMesh();
			this.LoadCells();
		}

		/// <summary>
		/// Generates a mesh for the ground that we can work with.
		/// </summary>
		private void LoadGroundMesh()
		{
			var vertices = _data.Vertices.Select(a => new Vector3f(a.X, a.Z, a.Y));
			var triangles = _data.Triangles.Select(a => new Index3i(a.Indices[0], a.Indices[1], a.Indices[2]));

			_mesh = DMesh3Builder.Build<Vector3f, Index3i, Vector3f>(vertices, triangles, null, null);

			_spatial = new DMeshAABBTree3(_mesh);
			_spatial.Build();
		}

		/// <summary>
		/// Generates cells from ground data.
		/// </summary>
		private void LoadCells()
		{
			_cells = new Polygon2d[_data.Cells.Length];

			for (var i = 0; i < _data.Cells.Length; ++i)
			{
				var vertices = _data.Cells[i].Vertices.Select(a => new Vector2d(a.X, a.Y)).ToArray();
				var polygon = new Polygon2d(vertices);

				_cells[i] = polygon;
			}
		}

		/// <summary>
		/// Returns whether the given 2D position is a valid position for
		/// an entity to stand on.
		/// </summary>
		/// <remarks>
		/// Only X and Z are used by this function.
		/// </remarks>
		/// <param name="pos"></param>
		/// <returns></returns>
		public bool IsValidPosition(Position pos)
		{
			return this.TryGetCellIndex(pos, out _);
		}

		/// <summary>
		/// Returns the height of the ground at the given 2D position.
		/// If there's no ground at the position, NaN is returned.
		/// </summary>
		/// <remarks>
		/// Only X and Z are used by this function.
		/// </remarks>
		/// <param name="pos"></param>
		/// <returns></returns>
		public float GetHeightAt(Position pos)
		{
			if (this.TryGetHeightAt(pos, out var height))
				return height;

			return float.NaN;
		}

		/// <summary>
		/// Returns the height of the ground at the given 2D position via
		/// out. Returns false if there is no ground at the position.
		/// </summary>
		/// <remarks>
		/// Only X and Z are used by this function.
		/// </remarks>
		/// <param name="pos"></param>
		/// <returns></returns>
		public bool TryGetHeightAt(Position pos, out float height)
		{
			if (_spatial == null)
			{
				height = -1;
				return false;
			}

			var origin = new Vector3f(pos.X, RayOriginHeight, pos.Z);
			var ray = new Ray3f(origin, new Vector3f(0, -1, 0));

			var hitId = _spatial.FindNearestHitTriangle(ray);
			if (hitId == DMesh3.InvalidID)
			{
				height = float.NaN;
				return false;
			}

			var intersection = MeshQueries.TriangleIntersection(_mesh, hitId, ray);
			var hitDistance = origin.Distance(ray.PointAt((float)intersection.RayParameter));

			height = (RayOriginHeight - hitDistance);
			return true;
		}

		/// <summary>
		/// Returns a copy of position, where Y is replaced with the cell
		/// index. If no cell could be found, Y is -1.
		/// </summary>
		/// <param name="pos"></param>
		/// <returns></returns>
		public Position GetCellPosition(Position pos)
		{
			this.TryGetCellIndex(pos, out var cellIndex);

			pos.Y = cellIndex;
			return pos;
		}

		/// <summary>
		/// Returns the cell index for the given position via out. Returns
		/// false if no cell exists at the position.
		/// </summary>
		/// <param name="pos"></param>
		/// <param name="cellIndex"></param>
		/// <returns></returns>
		public bool TryGetCellIndex(Position pos, out int cellIndex)
		{
			if (_data == null)
			{
				cellIndex = -1;
				return false;
			}

			var vecPos = new Vector2d(pos.X, pos.Z);

			// TODO: Quadtree?

			for (var i = 0; i < _data.Cells.Length; ++i)
			{
				var cell = _cells[i];

				if (cell.Contains(vecPos))
				{
					cellIndex = i;
					return true;
				}
			}

			cellIndex = -1;
			return false;
		}

		/// <summary>
		/// Returns a random position on the walkable ground via out.
		/// Returns false if no valid position could be found in a
		/// reasonable amount of time, indicating that the terrain
		/// is too complex.
		/// </summary>
		/// <returns></returns>
		public bool TryGetRandomPosition(out Position pos)
		{
			if (_cells == null || _cells.Length == 0)
			{
				pos = Position.Zero;
				return false;
			}

			// We choose a random cell to find a valid position on and
			// then simply try a few positions until we got one. This
			// is better than just trying random positions, but we could
			// still fail to find one. This is unlikely to ever be a big
			// problem, but we could optimize this to get a random triangle
			// to find a position on.

			var rnd = RandomProvider.Get();
			var rndCell = _cells[rnd.Next(_cells.Length)];

			var left = rndCell.Bounds.Min.x;
			var right = rndCell.Bounds.Max.x;
			var bottom = rndCell.Bounds.Min.y;
			var top = rndCell.Bounds.Max.y;

			for (var i = 0; i < 50; ++i)
			{
				var x = rnd.Next((int)left + 1, (int)right);
				var z = rnd.Next((int)bottom + 1, (int)top);

				pos = new Position(x, 0, z);
				if (!this.TryGetHeightAt(pos, out var height))
					continue;

				pos.Y = height;
				return true;
			}

			pos = Position.Zero;
			return false;
		}

		/// <summary>
		/// Returns the last valid position on the path between origin and
		/// destination. If there are no obstacles between the two positions,
		/// the position returned is the destination.
		/// </summary>
		/// <param name="origin"></param>
		/// <param name="destination"></param>
		/// <returns></returns>
		public Position GetLastValidPosition(Position origin, Position destination)
		{
			var dir = origin.GetDirection(destination);

			var stepSize = 10;
			var currentPos = origin;
			var lastValidPos = currentPos;

			while (currentPos.Get2DDistance(destination) > stepSize)
			{
				currentPos = currentPos.GetRelative(dir, stepSize);

				if (!this.TryGetHeightAt(currentPos, out var height))
					return lastValidPos;

				lastValidPos = currentPos;
				lastValidPos.Y = height;
			}

			return destination;
		}

		/// <summary>
		/// Returns the last valid center position of a circle on the path
		/// between the center and destination. If there are no obstacles
		/// between the two positions, the position returned is the center of
		/// circle at destination.
		/// </summary>
		/// <param name="originCenter"></param>
		/// <param name="radius"></param>
		/// <param name="destinationCenter"></param>
		/// <returns></returns>
		public Position GetLastValidCirclePosition(Position originCenter, float radius, Position destinationCenter)
		{
			var dir = originCenter.GetDirection(destinationCenter);
			var stepSize = 10;
			var currentPos = originCenter;
			var lastValidPos = currentPos;

			while (currentPos.Get2DDistance(destinationCenter) > stepSize)
			{
				currentPos = currentPos.GetRelative(dir, stepSize);

				if (!this.TryGetHeightAt(currentPos, out var height))
					return lastValidPos;

				if (!this.IsValidCirclePosition(currentPos, radius))
					return lastValidPos;

				lastValidPos = currentPos;
				lastValidPos.Y = height;
			}

			return destinationCenter;
		}

		/// <summary>
		/// Checks if the circle at the given center position with the
		/// specified radius is valid by verifying the heights at 8 points
		/// on its perimeter.
		/// </summary>
		/// <param name="center"></param>
		/// <param name="radius"></param>
		/// <returns></returns>
		public bool IsValidCirclePosition(Position center, float radius)
		{
			var perimeterOffsets = new List<Vector2f>
			{
				new Vector2f(radius, 0),
				new Vector2f(-radius, 0),
				new Vector2f(0, radius),
				new Vector2f(0, -radius),
				new Vector2f(radius / Math.Sqrt(2), radius / Math.Sqrt(2)),
				new Vector2f(-radius / Math.Sqrt(2), radius / Math.Sqrt(2)),
				new Vector2f(radius / Math.Sqrt(2), -radius / Math.Sqrt(2)),
				new Vector2f(-radius / Math.Sqrt(2), -radius / Math.Sqrt(2))
			};

			foreach (var offset in perimeterOffsets)
			{
				var perimeterPos = new Position(center.X + offset.x, center.Y, center.Z + offset.y);

				if (!this.TryGetHeightAt(perimeterPos, out var height))
					return false;
			}

			return true;
		}

		/// <summary>
		/// Calculates the bounding box of 2D ground data.
		/// Returns via out.
		/// </summary>
		/// <param name="sizeX"></param>
		/// <param name="sizeY"></param>
		public void GetBoundingBox(out double sizeX, out double sizeY)
		{
			sizeX = (_cells.Max(cell => cell.Bounds.Max.x) - _cells.Min(cell => cell.Bounds.Min.x));
			sizeY = (_cells.Max(cell => cell.Bounds.Max.y) - _cells.Min(cell => cell.Bounds.Min.y));
		}
	}
}
