//--- Melia Script -----------------------------------------------------------
// f_flash_59
//
//--- Description -----------------------------------------------------------
// Sets up the f_flash_59 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FFlash59MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_flash_59", MonsterId.Jukopus_Gray, Properties("MHP", 272618, "MINPATK", 4007, "MAXPATK", 4826, "MINMATK", 4007, "MAXMATK", 4826, "DEF", 16229, "MDEF", 16229));
		AddPropertyOverrides("f_flash_59", MonsterId.Rambear, Properties("MHP", 272936, "MINPATK", 4011, "MAXPATK", 4831, "MINMATK", 4011, "MAXMATK", 4831, "DEF", 16288, "MDEF", 16288));
		AddPropertyOverrides("f_flash_59", MonsterId.Goblin2_Wand1, Properties("MHP", 273518, "MINPATK", 4019, "MAXPATK", 4840, "MINMATK", 4019, "MAXMATK", 4840, "DEF", 16396, "MDEF", 16396));

		// Monster Spawners --------------------------------

		AddSpawner(MonsterId.Jukopus_Gray, 30, TimeSpan.FromMilliseconds(0), "Spawner1.f_flash_59");
		AddSpawner(MonsterId.Rootcrystal_01, 15, TimeSpan.FromMilliseconds(20000), "Spawner2.f_flash_59");
		AddSpawner(MonsterId.Rambear, 12, TimeSpan.FromMilliseconds(0), "Spawner3.f_flash_59");
		AddSpawner(MonsterId.Goblin2_Wand1, 10, TimeSpan.FromMilliseconds(0), "Spawner4.f_flash_59");
		AddSpawner(MonsterId.Rambear, 15, TimeSpan.FromMilliseconds(0), "Spawner5.f_flash_59");
		AddSpawner(MonsterId.Jukopus_Gray, 75, TimeSpan.FromMilliseconds(0), "Spawner6.f_flash_59");
		AddSpawner(MonsterId.Rambear, 5, TimeSpan.FromMilliseconds(0), "Spawner7.f_flash_59");
		AddSpawner(MonsterId.Jukopus_Gray, 8, TimeSpan.FromMilliseconds(0), "Spawner8.f_flash_59");

		// Monster Spawn Points -----------------------------

		// Jukopus_Gray Spawn Points
		AddSpawnPoint("f_flash_59", Spot(86.62844, 207.44952, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(612.28687, -182.76294, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(760.61426, -289.22556, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(823.44727, -87.12657, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-99.80731, -338.50012, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-327.22632, -342.73395, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(712.0604, 100.89166, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(82.60053, -313.8647, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(919.9426, 538.33545, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(965.9873, 765.687, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1042.3112, 640.8733, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1133.5348, 483.90625, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1151.547, 668.0427, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(317.4609, 231.67345, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(131.6693, 450.00824, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(249.63452, 457.1765, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1107.5929, -228.60756, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1090.0701, -29.429026, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1183.4487, 100.11961, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1269.3477, -240.8259, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1344.1849, -82.49204, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1195.854, -78.309494, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(575.7674, -614.44135, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(791.77954, -595.43134, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-797.12994, 382.87595, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-913.061, 481.014, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-827.71735, -1201.2944, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-999.41614, -980.1157, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-643.7075, -1039.6998, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-808.71967, -849.35046, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-815.1384, -1011.8509, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1459.3002, -380.50842, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1087.3855, -347.14343, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1291.4456, -374.65384, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(921.8532, 654.4493, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1066.3197, 754.41815, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1166.719, 560.1496, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1004.5851, 502.7613, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(814.13214, 565.6814, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1221.0558, 502.96478, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(853.9488, 451.11697, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(872.5427, 770.52905, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-950.0024, -1140.2997, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-955.6191, -1022.3952, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-910.5843, -917.3574, 30), "Spawner1.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-765.5818, -946.41736, 30), "Spawner1.f_flash_59");

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint("f_flash_59", Spot(-39.901264, 509.95752, 100), "Spawner2.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1037.3091, 746.70667, 100), "Spawner2.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1157.8239, 555.83075, 100), "Spawner2.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(875.70703, 492.78687, 100), "Spawner2.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(568.7194, -69.05843, 100), "Spawner2.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(621.63324, -255.27965, 100), "Spawner2.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(413.77347, -266.20636, 100), "Spawner2.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(727.9072, 92.60477, 100), "Spawner2.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1224.6235, -58.905098, 100), "Spawner2.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1162.067, -157.10349, 100), "Spawner2.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(763.223, -581.62573, 100), "Spawner2.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(540.4544, -574.19775, 100), "Spawner2.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-109.53906, -264.87234, 100), "Spawner2.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-387.7085, -351.16122, 100), "Spawner2.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-909.1747, -1064.3716, 100), "Spawner2.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-744.3725, -957.1161, 100), "Spawner2.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1457.3634, -338.16296, 100), "Spawner2.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1147.3258, -322.4789, 100), "Spawner2.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-796.7357, 352.96664, 100), "Spawner2.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-712.75037, 441.37775, 100), "Spawner2.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-840.1141, -31.470543, 100), "Spawner2.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-436.765, 427.5626, 100), "Spawner2.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(360.95398, 266.6242, 100), "Spawner2.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(299.4719, 492.79318, 100), "Spawner2.f_flash_59");

		// Rambear Spawn Points
		AddSpawnPoint("f_flash_59", Spot(-13.061993, 92.30318, 30), "Spawner3.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-54.855965, 299.20587, 30), "Spawner3.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(295.0324, 169.4516, 30), "Spawner3.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(308.06354, 504.29883, 30), "Spawner3.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(343.37042, 348.548, 30), "Spawner3.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(172.46945, 463.64975, 30), "Spawner3.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(24.681713, 509.55658, 30), "Spawner3.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(171.46567, 310.61456, 30), "Spawner3.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(55.73487, 216.06117, 30), "Spawner3.f_flash_59");

		// Goblin2_Wand1 Spawn Points
		AddSpawnPoint("f_flash_59", Spot(642.81384, -250.19496, 25), "Spawner4.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(751.06635, -73.587234, 25), "Spawner4.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(603.6678, -674.2955, 25), "Spawner4.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(832.06323, -592.7873, 25), "Spawner4.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1224.8296, 94.86319, 25), "Spawner4.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1179.7223, -201.00093, 25), "Spawner4.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-792.02795, -1166.7, 25), "Spawner4.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-904.79474, -963.5924, 25), "Spawner4.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(508.9156, -507.44534, 25), "Spawner4.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1047.7844, -49.491364, 25), "Spawner4.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1332.6287, -62.0604, 25), "Spawner4.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(723.37885, 102.67434, 25), "Spawner4.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(969.25256, 600.31555, 25), "Spawner4.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1130.0883, 645.6674, 25), "Spawner4.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(982.78766, 767.2041, 25), "Spawner4.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(864.5414, 539.43915, 25), "Spawner4.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1101.9935, 524.1839, 25), "Spawner4.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(888.42017, 706.4406, 25), "Spawner4.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1346.6033, -381.34512, 25), "Spawner4.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-722.5863, -356.69684, 25), "Spawner4.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-677.47266, -196.64908, 25), "Spawner4.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-272.70895, -348.40417, 25), "Spawner4.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-35.40973, -76.240326, 25), "Spawner4.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-2.679203, -314.53622, 25), "Spawner4.f_flash_59");

		// Rambear Spawn Points
		AddSpawnPoint("f_flash_59", Spot(-1459.138, -416.66248, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1716.492, -351.95053, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1392.0573, -270.70618, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1147.9209, -415.60193, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1316.9766, -401.77744, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1584.1345, -319.2363, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1103.994, -269.32285, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-907.8912, -1062.6515, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-908.924, -892.0815, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-721.59564, -1096.2734, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-664.71826, -868.75305, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-789.4819, -985.97705, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-910.8632, -1213.3906, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-686.25964, -1216.4788, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-498.63007, -345.48215, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-381.99628, -265.19836, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-381.07938, -366.63654, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-172.8136, -298.17114, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-19.25357, -412.95154, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-4.4302635, -300.6858, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(929.5264, 535.67316, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1113.9131, 768.9713, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1168.0331, 578.54755, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-904.81, 370.15137, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-686.434, 441.27325, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-721.6864, 298.07468, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-884.0384, 481.98392, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-777.0298, 374.90244, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-76.08736, 141.07817, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(10.307709, 142.8492, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(52.55208, 81.99848, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(74.73112, 48.409492, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1.2325706, 40.165054, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-56.789856, 65.08269, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-76.53263, 102.44179, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(49.46408, 141.03825, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(92.71257, 121.50842, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(48.51601, 114.94503, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(139.04233, 124.80203, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(210.21518, 139.5963, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(223.13086, 175.31253, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(269.57724, 142.28775, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(336.487, 126.24413, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(347.3879, 175.24513, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(385.10126, 221.07156, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(298.1766, 205.90213, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(260.49408, 231.06877, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(192.94644, 225.0463, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(254.22195, 202.41898, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(157.51175, 175.19017, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(126.42493, 217.77263, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(96.43098, 169.30879, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(21.633766, 184.33348, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-37.47081, 184.409, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-36.120667, 132.86934, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-89.91628, 194.33682, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(0.6225319, 255.19365, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-79.881966, 253.15091, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-123.05721, 328.06168, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-136.90877, 385.774, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-19.727057, 363.54556, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-50.468815, 456.49405, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(90.9317, 502.98914, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(104.69249, 426.161, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(120.80043, 551.1547, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(171.58138, 531.7556, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(251.54005, 509.5483, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(140.20546, 501.48203, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-57.928318, 534.73773, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(4.879613, 460.6136, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-103.29498, 415.7489, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-135.94193, 518.48517, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-95.92389, 574.02576, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(65.86582, 576.01624, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-59.042397, 361.36707, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-18.08841, 239.96065, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(138.23453, 376.02545, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(271.3732, 396.40012, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-716.65765, 349.02325, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-671.0534, 341.64685, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-713.80927, 406.53345, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-792.1948, 453.9169, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-780.971, 326.2517, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-823.3453, 336.2528, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-858.6941, 337.28232, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-918.64557, 310.2141, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-962.1088, 307.32297, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-989.1896, 358.4426, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-973.4968, 394.64053, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-931.2651, 441.22366, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-854.51984, 425.1293, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-854.7354, 382.7946, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-835.3371, 470.51395, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-754.5435, 490.9151, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-755.32367, 417.5323, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-906.13135, 417.3732, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-959.8669, 365.78625, 30), "Spawner5.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-647.2939, 394.3187, 30), "Spawner5.f_flash_59");

		// Jukopus_Gray Spawn Points
		AddSpawnPoint("f_flash_59", Spot(-719.1606, -1173.7037, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-812.907, -1179.6456, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-889.02155, -1071.141, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-960.64966, -935.84436, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-854.2026, -896.52057, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-707.0482, -910.8823, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-633.98035, -900.1795, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-627.0414, -1020.3149, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-732.9848, -1007.7767, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-813.82416, -1035.9207, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1322.7108, -186.00401, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1358.0923, -205.37329, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1303.4099, -287.74164, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1326.3281, -239.58914, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1215.4963, -275.1137, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1144.5985, -265.972, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1214.9042, -230.8246, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1390.5422, -145.69733, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1336.941, -126.41005, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1280.182, -158.29047, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1237.4548, -199.1304, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1159.207, -147.99805, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1090.3643, -165.17004, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1042.8069, -111.96729, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1102.0934, -88.83095, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1182.1859, -2.183445, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1262.3772, -7.1488037, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1282.1062, -76.88367, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1237.3844, -51.21962, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1224.7157, -131.40515, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1130.5317, -39.726936, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1324.8525, 19.012917, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1236.0664, 46.82833, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1152.321, 51.662457, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1102.0038, 114.43794, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1233.5072, 148.30627, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1169.4137, 150.74915, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1106.3129, 42.24929, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1059.3766, 19.401985, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1118.1764, 3.8941514, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(836.8197, -21.26419, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(769.5318, -37.31758, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(737.5975, 42.00396, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(824.41907, 75.52742, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(814.5384, 173.14252, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(745.1094, 186.7095, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(687.83044, 219.45908, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(615.0056, 181.24861, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(563.4531, 133.38972, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(491.13272, 59.4961, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(439.92737, 73.77822, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(444.6356, 31.339298, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(496.12277, 143.28986, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(686.2571, 40.01854, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(630.9284, 56.497353, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(562.2074, -38.826935, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(435.23505, -10.952717, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(382.73624, -133.22253, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(396.91885, -221.44516, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(383.35068, -265.62405, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(469.90982, -243.31961, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(514.493, -284.12286, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(611.4966, -294.52652, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(474.94586, -307.50284, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(592.1375, -235.23993, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(713.7998, -274.23633, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(738.3976, -208.80806, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(698.0504, -127.54677, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(627.5864, -92.10071, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(710.13794, -78.536285, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(470.74106, -569.9788, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(562.9736, -509.84143, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(528.1411, -659.15247, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(680.06, -741.0418, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(670.1887, -703.56323, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(704.36865, -633.8156, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(752.45667, -674.7357, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(780.5933, -626.9562, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(859.66785, -637.29126, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(748.5119, -581.38477, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(711.5119, -545.38776, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(629.49396, -523.94586, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(769.4811, -494.3274, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(752.145, -454.62027, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(748.0698, -552.4823, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(875.7923, -537.5168, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(900.7412, -599.8349, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(821.4823, -624.2035, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(619.1113, -611.75165, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(668.42584, -656.67694, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(430.59015, -94.29029, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(462.10367, -158.9778, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(561.2678, -160.64493, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(551.9808, -101.90112, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(487.11914, -60.090294, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(529.3729, -196.39601, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(814.284, -139.30025, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(664.00464, -14.316353, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(636.36554, 130.09819, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(571.9341, 50.41443, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(1.1271067, -212.66702, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(114.17117, -283.5609, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(46.50558, -283.31952, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1.3036041, -154.0963, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-17.62224, -238.09825, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(33.10017, -361.4519, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-40.119316, -356.023, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-62.254784, -302.12463, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-120.44848, -299.48477, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-141.50664, -360.5245, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-211.2651, -364.90387, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-270.47812, -301.2484, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-218.90758, -310.93848, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-346.9641, -284.47083, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-412.6424, -320.48984, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-452.411, -386.48846, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-500.6097, -309.91635, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-561.94495, -313.03882, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-643.962, -310.1651, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-709.8709, -265.65137, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-649.3459, -370.63986, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-579.6786, -426.2457, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-571.1781, -347.5429, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-530.6483, -382.83224, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-611.1955, -272.94336, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-622.0825, -427.9669, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-703.0553, -315.6368, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-460.0782, -308.9311, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-319.02225, -386.63324, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-227.01752, -393.42337, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-894.7037, -1168.6924, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-806.369, -1110.8737, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-660.75543, -1132.8898, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-676.0114, -1088.2665, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-730.35815, -1129.8655, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-648.7452, -959.1491, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-743.77765, -892.6712, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-857.50415, -977.4144, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-963.39734, -881.96295, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-863.37274, -842.0227, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1095.5594, -397.22278, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1136.9523, -334.79056, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1043.481, -248.38501, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1043.663, -299.04288, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1161.042, -286.20865, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1208.0881, -379.48428, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1259.3379, -312.9962, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1200.2692, -314.5351, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1302.4193, -321.0736, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1259.4385, -398.7154, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1348.7568, -268.05972, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1385.9746, -356.66986, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1291.8851, -261.71994, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1403.0693, -392.95676, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1468.1022, -312.42105, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1413.1783, -306.0268, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1504.6624, -354.20325, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1532.8533, -288.23627, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1557.7478, -341.75592, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1643.8522, -317.07397, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1658.3375, -364.1469, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1661.605, -401.7544, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1693.1224, -303.9276, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1636.1796, -254.24255, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1599.2102, -275.4124, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1609.6055, -355.74835, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1562.0093, -371.6854, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1538.2369, -258.60013, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1451.3312, -265.5087, 50), "Spawner6.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-1430.2589, -350.5199, 50), "Spawner6.f_flash_59");

		// Rambear Spawn Points
		AddSpawnPoint("f_flash_59", Spot(-799.6757, -1240.7201, 40), "Spawner7.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-987.7676, -1087.1383, 40), "Spawner7.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-950.7115, -984.7605, 40), "Spawner7.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-857.9023, -922.8541, 40), "Spawner7.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-664.38495, -881.9228, 40), "Spawner7.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-572.71313, -920.4248, 40), "Spawner7.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-618.3919, -1091.1328, 40), "Spawner7.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-681.8742, -1191.9463, 40), "Spawner7.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-970.7613, -1220.1841, 40), "Spawner7.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-848.0472, -1145.8414, 40), "Spawner7.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-701.486, -1024.2051, 40), "Spawner7.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(-822.68097, -1058.4686, 40), "Spawner7.f_flash_59");

		// Jukopus_Gray Spawn Points
		AddSpawnPoint("f_flash_59", Spot(572.9951, -645.1228, 30), "Spawner8.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(526.9635, -555.69135, 30), "Spawner8.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(599.3689, -484.70358, 30), "Spawner8.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(685.9967, -507.38443, 30), "Spawner8.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(665.10583, -558.6206, 30), "Spawner8.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(862.3802, -574.9805, 30), "Spawner8.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(811.3597, -656.0435, 30), "Spawner8.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(713.6181, -695.3487, 30), "Spawner8.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(620.94775, -721.7745, 30), "Spawner8.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(732.83575, -621.11487, 30), "Spawner8.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(511.86346, -624.4905, 30), "Spawner8.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(653.81067, -447.74313, 30), "Spawner8.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(772.2467, -530.2135, 30), "Spawner8.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(794.1476, -600.1719, 30), "Spawner8.f_flash_59");
		AddSpawnPoint("f_flash_59", Spot(902.773, -569.43427, 30), "Spawner8.f_flash_59");

	}
}
