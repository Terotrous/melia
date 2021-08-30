﻿// Copyright (c) Aura development team - Licensed under GNU GPL
// For more information, see license file in the main folder

using System;
using System.Linq;
using Melia.Shared.Const;
using Newtonsoft.Json.Linq;

namespace Melia.Shared.Data.Database
{
	[Serializable]
	public class SkillTreeData
	{
		public JobId JobId { get; set; }
		public int SkillId { get; set; }
		public int UnlockLevel { get; set; }
		public int MaxLevel { get; set; }
	}

	/// <summary>
	/// Skill tree database.
	/// </summary>
	public class SkillTreeDb : DatabaseJson<SkillTreeData>
	{
		/// <summary>
		/// Returns all skills the given job can learn at a certain circle.
		/// </summary>
		/// <param name="jobId"></param>
		/// <param name="circle"></param>
		/// <returns></returns>
		public SkillTreeData[] FindSkills(JobId jobId, int classLevel)
		{
			return this.Entries.Where(a => a.JobId == jobId && a.UnlockLevel <= classLevel).ToArray();
		}

		protected override void ReadEntry(JObject entry)
		{
			entry.AssertNotMissing("jobId", "skillId", "unlockLevel", "maxLevel");

			var data = new SkillTreeData();

			data.JobId = (JobId)entry.ReadInt("jobId");
			data.SkillId = entry.ReadInt("skillId");
			data.UnlockLevel = entry.ReadInt("unlockLevel");
			data.MaxLevel = entry.ReadInt("maxLevel");

			this.Entries.Add(data);
		}
	}
}
