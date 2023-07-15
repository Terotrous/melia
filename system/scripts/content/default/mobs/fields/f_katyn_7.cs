//--- Melia Script -----------------------------------------------------------
// f_katyn_7
//
//--- Description -----------------------------------------------------------
// Sets up the f_katyn_7 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FKatyn7MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner(MonsterId.Rootcrystal_02, 20, "SpawnPointCollection1.f_katyn_7", TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Ellom, 30, "SpawnPointCollection2.f_katyn_7", TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner(MonsterId.Pappus_Kepa, 20, "SpawnPointCollection3.f_katyn_7", TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner(MonsterId.Bushspider, 15, "SpawnPointCollection4.f_katyn_7", TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner(MonsterId.Pappus_Kepa, 12, "SpawnPointCollection5.f_katyn_7", TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner(MonsterId.Ellom, 7, "SpawnPointCollection6.f_katyn_7", TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner(MonsterId.Bushspider, 15, "SpawnPointCollection7.f_katyn_7", TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner(MonsterId.Fisherman, 10, "SpawnPointCollection8.f_katyn_7", TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner(MonsterId.Ellom, 10, "SpawnPointCollection9.f_katyn_7", TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner(MonsterId.Fisherman, 3, "SpawnPointCollection10.f_katyn_7", TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_02 Spawn Points
		AddSpawnPoint("f_katyn_7", Spot(-1223, 3370, 30), "SpawnPointCollection1.f_katyn_7");

		// Ellom Spawn Points
		AddSpawnPoint("f_katyn_7", Spot(927.6994, -2268.3066, 9999), "SpawnPointCollection2.f_katyn_7");

		// Pappus_Kepa Spawn Points
		AddSpawnPoint("f_katyn_7", Spot(-1008.579, 34.71529, 9999), "SpawnPointCollection3.f_katyn_7");

		// Bushspider Spawn Points
		AddSpawnPoint("f_katyn_7", Spot(-1258.1116, 1744.982, 9999), "SpawnPointCollection4.f_katyn_7");

		// Pappus_Kepa Spawn Points
		AddSpawnPoint("f_katyn_7", Spot(-195, 1798, 30), "SpawnPointCollection5.f_katyn_7");
		AddSpawnPoint("f_katyn_7", Spot(-408.50067, 1903.7605, 30), "SpawnPointCollection5.f_katyn_7");
		AddSpawnPoint("f_katyn_7", Spot(-357.05298, 2160.783, 30), "SpawnPointCollection5.f_katyn_7");
		AddSpawnPoint("f_katyn_7", Spot(-447.0964, 2034.5729, 30), "SpawnPointCollection5.f_katyn_7");
		AddSpawnPoint("f_katyn_7", Spot(-212.75533, 1626.2478, 30), "SpawnPointCollection5.f_katyn_7");
		AddSpawnPoint("f_katyn_7", Spot(-77.39426, 1555.8328, 30), "SpawnPointCollection5.f_katyn_7");
		AddSpawnPoint("f_katyn_7", Spot(-165.34433, 1424.4225, 30), "SpawnPointCollection5.f_katyn_7");
		AddSpawnPoint("f_katyn_7", Spot(-177.28043, 1222.3451, 30), "SpawnPointCollection5.f_katyn_7");
		AddSpawnPoint("f_katyn_7", Spot(-2.4099197, 890.81885, 30), "SpawnPointCollection5.f_katyn_7");
		AddSpawnPoint("f_katyn_7", Spot(-168.38225, 660.0151, 30), "SpawnPointCollection5.f_katyn_7");
		AddSpawnPoint("f_katyn_7", Spot(-377.47775, 1053.2151, 30), "SpawnPointCollection5.f_katyn_7");

		// Ellom Spawn Points
		AddSpawnPoint("f_katyn_7", Spot(-766.02924, 3256.867, 275), "SpawnPointCollection6.f_katyn_7");

		// Bushspider Spawn Points
		AddSpawnPoint("f_katyn_7", Spot(-227.57834, 958.3283, 30), "SpawnPointCollection7.f_katyn_7");
		AddSpawnPoint("f_katyn_7", Spot(-438.8225, 920.1881, 30), "SpawnPointCollection7.f_katyn_7");
		AddSpawnPoint("f_katyn_7", Spot(-333.58322, 1109.5657, 30), "SpawnPointCollection7.f_katyn_7");
		AddSpawnPoint("f_katyn_7", Spot(-399.75397, 614.409, 30), "SpawnPointCollection7.f_katyn_7");
		AddSpawnPoint("f_katyn_7", Spot(-178.58769, 670.884, 30), "SpawnPointCollection7.f_katyn_7");
		AddSpawnPoint("f_katyn_7", Spot(-371.37378, 747.3366, 30), "SpawnPointCollection7.f_katyn_7");
		AddSpawnPoint("f_katyn_7", Spot(-63.39987, 1058.0623, 30), "SpawnPointCollection7.f_katyn_7");
		AddSpawnPoint("f_katyn_7", Spot(-32.866924, 1271.0573, 30), "SpawnPointCollection7.f_katyn_7");
		AddSpawnPoint("f_katyn_7", Spot(-184.69601, 1310.3783, 30), "SpawnPointCollection7.f_katyn_7");
		AddSpawnPoint("f_katyn_7", Spot(33.831566, 776.466, 30), "SpawnPointCollection7.f_katyn_7");
		AddSpawnPoint("f_katyn_7", Spot(-179.23944, 1660.6945, 30), "SpawnPointCollection7.f_katyn_7");
		AddSpawnPoint("f_katyn_7", Spot(-502.4433, 1086.6884, 30), "SpawnPointCollection7.f_katyn_7");

		// Fisherman Spawn Points
		AddSpawnPoint("f_katyn_7", Spot(-281.53958, -737.38257, 9999), "SpawnPointCollection8.f_katyn_7");

		// Ellom Spawn Points
		AddSpawnPoint("f_katyn_7", Spot(-742.2518, 3321.5752, 20), "SpawnPointCollection9.f_katyn_7");
		AddSpawnPoint("f_katyn_7", Spot(-933.58466, 3145.1191, 20), "SpawnPointCollection9.f_katyn_7");
		AddSpawnPoint("f_katyn_7", Spot(-1172.1798, 3226.943, 20), "SpawnPointCollection9.f_katyn_7");
		AddSpawnPoint("f_katyn_7", Spot(-924.4441, 3302.0566, 20), "SpawnPointCollection9.f_katyn_7");
		AddSpawnPoint("f_katyn_7", Spot(-921.4084, 3545.3196, 20), "SpawnPointCollection9.f_katyn_7");
		AddSpawnPoint("f_katyn_7", Spot(-484.0555, 3375.5715, 20), "SpawnPointCollection9.f_katyn_7");
		AddSpawnPoint("f_katyn_7", Spot(-479.45477, 3502.4744, 20), "SpawnPointCollection9.f_katyn_7");
		AddSpawnPoint("f_katyn_7", Spot(-1328.2063, 3419.2942, 20), "SpawnPointCollection9.f_katyn_7");
		AddSpawnPoint("f_katyn_7", Spot(-849.8979, 3723.3157, 20), "SpawnPointCollection9.f_katyn_7");
		AddSpawnPoint("f_katyn_7", Spot(-299.75748, 3409.9426, 20), "SpawnPointCollection9.f_katyn_7");

		// Fisherman Spawn Points
		AddSpawnPoint("f_katyn_7", Spot(-2046.5919, 1274.36, 400), "SpawnPointCollection10.f_katyn_7");

	}
}
