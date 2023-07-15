//--- Melia Script -----------------------------------------------------------
// id_Unknownsanctuary_2
//
//--- Description -----------------------------------------------------------
// Sets up the id_Unknownsanctuary_2 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class IdUnknownsanctuary2MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Velcoffer, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Kucarry_Balzermancer, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Wastrel, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Ignas, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Asiomage, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Skiaclipse, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Moringponia, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Tantaliser, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Pbeta, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Glacier, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));
		AddPropertyOverrides("id_Unknownsanctuary_2", MonsterId.FD_Boss_Froster_Lord, Properties("MHP", 600000000, "MINPATK", 250000, "MAXPATK", 250000, "MINMATK", 250000, "MAXMATK", 250000, "DEF", 3000000, "MDEF", 3000000));

		// Monster Spawners --------------------------------

		AddSpawner(MonsterId.FD_Boss_Velcoffer, 1, "SpawnPointCollection1.id_Unknownsanctuary_2", TimeSpan.FromMilliseconds(15000), TendencyType.Aggressive);
		AddSpawner(MonsterId.FD_Boss_Kucarry_Balzermancer, 1, "SpawnPointCollection2.id_Unknownsanctuary_2", TimeSpan.FromMilliseconds(15000), TendencyType.Aggressive);
		AddSpawner(MonsterId.FD_Boss_Wastrel, 1, "SpawnPointCollection3.id_Unknownsanctuary_2", TimeSpan.FromMilliseconds(15000), TendencyType.Aggressive);
		AddSpawner(MonsterId.FD_Boss_Ignas, 1, "SpawnPointCollection4.id_Unknownsanctuary_2", TimeSpan.FromMilliseconds(15000), TendencyType.Aggressive);
		AddSpawner(MonsterId.FD_Boss_Asiomage, 1, "SpawnPointCollection5.id_Unknownsanctuary_2", TimeSpan.FromMilliseconds(15000), TendencyType.Aggressive);
		AddSpawner(MonsterId.FD_Boss_Skiaclipse, 1, "SpawnPointCollection6.id_Unknownsanctuary_2", TimeSpan.FromMilliseconds(15000), TendencyType.Aggressive);
		AddSpawner(MonsterId.FD_Boss_Moringponia, 1, "SpawnPointCollection7.id_Unknownsanctuary_2", TimeSpan.FromMilliseconds(15000), TendencyType.Aggressive);
		AddSpawner(MonsterId.FD_Boss_Tantaliser, 1, "SpawnPointCollection8.id_Unknownsanctuary_2", TimeSpan.FromMilliseconds(15000), TendencyType.Aggressive);
		AddSpawner(MonsterId.FD_Boss_Pbeta, 1, "SpawnPointCollection9.id_Unknownsanctuary_2", TimeSpan.FromMilliseconds(15000), TendencyType.Aggressive);
		AddSpawner(MonsterId.FD_Boss_Glacier, 1, "SpawnPointCollection10.id_Unknownsanctuary_2", TimeSpan.FromMilliseconds(15000), TendencyType.Aggressive);
		AddSpawner(MonsterId.FD_Boss_Froster_Lord, 1, "SpawnPointCollection11.id_Unknownsanctuary_2", TimeSpan.FromMilliseconds(15000), TendencyType.Aggressive);
		AddSpawner(MonsterId.FD_Boss_Skiaclipse, 1, "SpawnPointCollection12.id_Unknownsanctuary_2", TimeSpan.FromMilliseconds(15000), TendencyType.Aggressive);
		AddSpawner(MonsterId.FD_Boss_Skiaclipse, 1, "SpawnPointCollection13.id_Unknownsanctuary_2", TimeSpan.FromMilliseconds(15000), TendencyType.Aggressive);

		// Monster Spawn Points -----------------------------

		// FD_Boss_Velcoffer Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2", Spot(86.288925, -17.487818, 20), "SpawnPointCollection1.id_Unknownsanctuary_2");

		// FD_Boss_Kucarry_Balzermancer Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2", Spot(-1055.728, -135.6764, 20), "SpawnPointCollection2.id_Unknownsanctuary_2");

		// FD_Boss_Wastrel Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2", Spot(866.08954, 1069.8341, 20), "SpawnPointCollection3.id_Unknownsanctuary_2");

		// FD_Boss_Ignas Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2", Spot(-426.4594, -1035.8777, 20), "SpawnPointCollection4.id_Unknownsanctuary_2");

		// FD_Boss_Asiomage Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2", Spot(68.01238, -1364.7366, 20), "SpawnPointCollection5.id_Unknownsanctuary_2");

		// FD_Boss_Skiaclipse Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2", Spot(-372.66635, -435.87714, 20), "SpawnPointCollection6.id_Unknownsanctuary_2");

		// FD_Boss_Moringponia Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2", Spot(-1057.1002, -807.03094, 20), "SpawnPointCollection7.id_Unknownsanctuary_2");

		// FD_Boss_Tantaliser Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2", Spot(1055.4669, 561.7357, 20), "SpawnPointCollection8.id_Unknownsanctuary_2");

		// FD_Boss_Pbeta Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2", Spot(541.70825, -1062.0155, 20), "SpawnPointCollection9.id_Unknownsanctuary_2");

		// FD_Boss_Glacier Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2", Spot(-803.96027, 767.3518, 20), "SpawnPointCollection10.id_Unknownsanctuary_2");

		// FD_Boss_Froster_Lord Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2", Spot(198.3233, 1156.4188, 20), "SpawnPointCollection11.id_Unknownsanctuary_2");

		// FD_Boss_Skiaclipse Spawn Points
		AddSpawnPoint("id_Unknownsanctuary_2", Spot(591.1201, -383.408, 20), "SpawnPointCollection12.id_Unknownsanctuary_2");
		AddSpawnPoint("id_Unknownsanctuary_2", Spot(-66.70287, 534.97064, 20), "SpawnPointCollection13.id_Unknownsanctuary_2");

	}
}
