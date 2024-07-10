﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Melia.Zone.World.Items;
using Melia.Shared.Data.Database;
using Melia.Shared.Scripting;
using Melia.Zone.Network;
using Melia.Zone.Scripting;
using Yggdrasil.Logging;
using Yggdrasil.Scheduling;
using Yggdrasil.Util;
using Melia.Shared.Game.Const;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Melia.Zone.World.Actors.Characters.Components
{
	/// <summary>
	/// A character's collection manager.
	/// </summary>
	/// <remarks>
	/// An important thing to note about the collection system is that Collections are account-level.
	/// </remarks>
	public class CollectionComponent : CharacterComponent
	{
		private class CollectionProgress
		{
			public CollectionData data;
			public List<int> registeredItems;
			public int redeemCount;

			public CollectionProgress(CollectionData data)
			{
				this.data = data;
				registeredItems = new List<int>();
				redeemCount = 0;
			}

			public bool registerItem(ItemData item)
			{
				if (!data.RequiredItems.Contains(item.ClassName))
					return false;

				var itemsNeeded = data.RequiredItems.Count(a => a.Equals(item.ClassName));
				var itemsAddedAlready = registeredItems.Count(a => a == item.Id);

				if (itemsAddedAlready >= itemsNeeded)
					return false;

				registeredItems.Add(item.Id);
				return true;
			}

			public bool isComplete
				=> data.RequiredItems.Count == registeredItems.Count;
		}

		private readonly object _syncLock = new object();
		private readonly Dictionary<int, CollectionProgress> _collectionList = new Dictionary<int, CollectionProgress>();

		/// <summary>
		/// Returns the total number of registered collections
		/// </summary>
		/// <returns></returns>
		public int Count
			=> _collectionList.Count;


		/// <summary>
		/// Creates new instance for character.
		/// </summary>
		/// <param name="character"></param>
		public CollectionComponent(Character character)
			: base(character)
		{
		}


		/// <summary>
		/// Creates a new empty Collection, optionally specifying the number of times it has already been redeemed
		/// <param name="collectionId"></param>
		/// <param name="redeemCount"></param>
		public bool Add(int collectionId, int redeemCount = 0)
		{
			lock (_syncLock)
			{
				if (ZoneServer.Instance.Data.CollectionDb.TryFind(collectionId, out var collectionData) && !_collectionList.ContainsKey(collectionId))
				{
					var newCollection = new CollectionProgress(collectionData);
					newCollection.redeemCount = redeemCount;
					_collectionList.Add(collectionId, newCollection);

					return true;
				}
				return false;
			}
		}


		/// <summary>
		/// Returns if a given collection is complete
		/// </summary>
		/// <param name="collectionId"></param>
		/// <returns>false if the collection isn't complete or hasn't been registered at all</returns>
		public bool isComplete(int collectionId)
		{
			lock (_syncLock)
			{
				if (_collectionList.TryGetValue(collectionId, out var collectionProgress))
					return collectionProgress.isComplete;
				else
					return false;
			}
		}


		/// <summary>
		/// Returns the number of times a given collection was redeemed
		/// </summary>
		/// <param name="collectionId"></param>
		/// <returns>0 if the collection isn't present at all</returns>
		public int getRedeemCount(int collectionId)
		{
			lock (_syncLock)
			{
				if (_collectionList.TryGetValue(collectionId, out var collectionProgress))
					return collectionProgress.redeemCount;
				else
					return 0;
			}
		}

		/// <summary>
		/// Gets a collection and returns the list of items registered to it.
		/// </summary>
		/// <param name="collectionId"></param>
		/// <param name="registeredItems"></param>
		/// <returns>false if the collection hasn't been registered at all</returns>
		public bool TryGetItems(int collectionId, out List<int> registeredItems)
		{
			lock (_syncLock)
			{
				if (_collectionList.TryGetValue(collectionId, out var collectionProgress)) {
					registeredItems = new List<int>(collectionProgress.registeredItems);
					return true;
				}
				else
				{
					registeredItems = null;
					return false;
				}
			}
		}		

		/// <summary>
		/// Returns the list of all collections the user has registered
		/// </summary>
		/// <returns></returns>
		public List<int> GetList()
		{
			lock (_syncLock)
				return _collectionList.Keys.ToList();
		}

		/// <summary>
		/// Returns the list of items currently registered to the given collection
		/// This list might be empty if no items are registered
		/// Returns null if the collection isn't registered at all
		/// </summary>
		/// <returns></returns>
		public List<int> GetProgress(int collectionId)
		{
			lock (_syncLock)
			{ 
				if (TryGetItems(collectionId, out var progress))
					return progress;
				return null;
			}
		}


		/// <summary>
		/// Registers an item to this collection
		/// <param name="collectionId"></param>
		/// <param name="item"></param>
		/// <param name="silent">Skips updating the client of any stat changes</param>
		/// </summary>
		public bool RegisterItem(int collectionId, ItemData item, bool silent = false)
		{
			lock (_syncLock)
			{
				if (!_collectionList.TryGetValue(collectionId, out var collectionProgress))
					return false;

				if (!collectionProgress.registerItem(item))
				{
					return false;
				}

				if (collectionProgress.isComplete)
				{
					if (collectionProgress.data.RewardProperties != "")
					{
						AddBonuses(collectionProgress.data.RewardProperties, silent);
					}						
				}
				return true;
			}
		}

		/// <summary>
		/// Grants bonus properties
		/// <param name="silent">Skips updating the client</param>
		/// <param name="multiplier">Multiplies by this amount, use -1 to remove the bonus</param>
		/// </summary>
		public void AddBonuses(string bonusProperties, bool silent = false, int multiplier = 1)
		{
			var properties = Character.Properties;

			string[] bonusList = bonusProperties.Split("/");
			if (bonusList.Length >= 2)
			{
				for (int i = 0; i < bonusList.Length; i += 2)
				{
					switch (bonusList[i])
					{
						case "STR_BM":
							properties.Modify(PropertyName.STR_BM, multiplier * float.Parse(bonusList[i + 1]));
							break;
						case "DEX_BM":
							properties.Modify(PropertyName.DEX_BM, multiplier * float.Parse(bonusList[i + 1]));
							break;
						case "INT_BM":
							properties.Modify(PropertyName.INT_BM, multiplier * float.Parse(bonusList[i + 1]));
							break;
						case "MNA_BM":
							properties.Modify(PropertyName.MNA_BM, multiplier * float.Parse(bonusList[i + 1]));
							break;
						case "CON_BM":
							properties.Modify(PropertyName.CON_BM, multiplier * float.Parse(bonusList[i + 1]));
							break;
						case "MHP_BM":
							properties.Modify(PropertyName.MHP_BM, multiplier * float.Parse(bonusList[i + 1]));
							break;
						case "MSP_BM":
							properties.Modify(PropertyName.MSP_BM, multiplier * float.Parse(bonusList[i + 1]));
							break;
						case "MaxSta_BM":
							properties.Modify(PropertyName.MaxSta_BM, multiplier * float.Parse(bonusList[i + 1]));
							break;
						case "MaxWeight_BM":
							properties.Modify(PropertyName.MaxWeight_BM, multiplier * float.Parse(bonusList[i + 1]));
							break;
						case "RHP_BM":
							properties.Modify(PropertyName.RHP_BM, multiplier * float.Parse(bonusList[i + 1]));
							break;
						case "RSP_BM":
							properties.Modify(PropertyName.RSP_BM, multiplier * float.Parse(bonusList[i + 1]));
							break;
						case "HR_BM":
							properties.Modify(PropertyName.HR_BM, multiplier * float.Parse(bonusList[i + 1]));
							break;
						case "DR_BM":
							properties.Modify(PropertyName.DR_BM, multiplier * float.Parse(bonusList[i + 1]));
							break;
						case "PATK_BM":
							properties.Modify(PropertyName.PATK_BM, multiplier * float.Parse(bonusList[i + 1]));
							break;
						case "MATK_BM":
							properties.Modify(PropertyName.MATK_BM, multiplier * float.Parse(bonusList[i + 1]));
							break;
						case "DEF_BM":
							properties.Modify(PropertyName.DEF_BM, multiplier * float.Parse(bonusList[i + 1]));
							break;
						case "MDEF_BM":
							properties.Modify(PropertyName.MDEF_BM, multiplier * float.Parse(bonusList[i + 1]));
							break;
						case "CRTATK_BM":
							properties.Modify(PropertyName.CRTATK_BM, multiplier * float.Parse(bonusList[i + 1]));
							break;
						case "CRTMATK_BM":
							properties.Modify(PropertyName.CRTMATK_BM, multiplier * float.Parse(bonusList[i + 1]));
							break;
						case "CRTHR_BM":
							properties.Modify(PropertyName.CRTHR_BM, multiplier * float.Parse(bonusList[i + 1]));
							break;
						case "CRTDR_BM":
							properties.Modify(PropertyName.CRTDR_BM, multiplier * float.Parse(bonusList[i + 1]));
							break;
						case "ResFire_BM":
							properties.Modify(PropertyName.ResFire_BM, multiplier * float.Parse(bonusList[i + 1]));
							break;
						case "ResIce_BM":
							properties.Modify(PropertyName.ResIce_BM, multiplier * float.Parse(bonusList[i + 1]));
							break;
						case "ResLightning_BM":
							properties.Modify(PropertyName.ResLightning_BM, multiplier * float.Parse(bonusList[i + 1]));
							break;
						case "ResEarth_BM":
							properties.Modify(PropertyName.ResEarth_BM, multiplier * float.Parse(bonusList[i + 1]));
							break;
						case "ResPoison_BM":
							properties.Modify(PropertyName.ResPoison_BM, multiplier * float.Parse(bonusList[i + 1]));
							break;
						case "ResDark_BM":
							properties.Modify(PropertyName.ResDark_BM, multiplier * float.Parse(bonusList[i + 1]));
							break;
						case "ResHoly_BM":
							properties.Modify(PropertyName.ResHoly_BM, multiplier * float.Parse(bonusList[i + 1]));
							break;
						case "BLK_BM":
							properties.Modify(PropertyName.BLK_BM, multiplier * float.Parse(bonusList[i + 1]));
							break;
						case "BLK_BREAK_BM":
							properties.Modify(PropertyName.BLK_BREAK_BM, multiplier * float.Parse(bonusList[i + 1]));
							break;
						default:
							Log.Warning("Unknown collection reward property specified: {0}", bonusList[i]);
							break;
					}
				}

				// Tell the system it needs to recalculate the character's stats unless silent mode is on
				if (!silent)
				{
					properties.InvalidateAll();
					Send.ZC_OBJECT_PROPERTY(Character);
				}
			}
		}


		/// <summary>
		/// Removes all bonus properties.  This must be done before saving the properties,
		/// so the bonuses don't infinitely stack
		/// <param name="silent">Skips updating the client</param>
		/// </summary>
		public void RemoveAllBonuses()
		{
			foreach (var key in _collectionList.Keys)
			{
				var collection = _collectionList[key];
				if (collection.isComplete && collection.data.RewardProperties != "")
				{
					AddBonuses(collection.data.RewardProperties, true, -1);
				}
			}
		}

		/// <summary>
		/// Redeems all available collections one time
		/// <param name="toCharacterStorage">If false, goes to team storage instead</param>
		/// </summary>
		public void RedeemAll(bool toCharacterStorage)
		{
			// TODO: unimplemented
		}
	}
}