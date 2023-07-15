//--- Melia Script -----------------------------------------------------------
// f_siauliai_46_1
//
//--- Description -----------------------------------------------------------
// Sets up the f_siauliai_46_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FSiauliai461MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_siauliai_46_1", MonsterId.Infro_Blud, Properties("MHP", 252801, "MINPATK", 3752, "MAXPATK", 4513, "MINMATK", 3752, "MAXMATK", 4513, "DEF", 13582, "MDEF", 13582));
		AddPropertyOverrides("f_siauliai_46_1", MonsterId.Shardstatue, Properties("MHP", 254850, "MINPATK", 3778, "MAXPATK", 4545, "MINMATK", 3778, "MAXMATK", 4545, "DEF", 13855, "MDEF", 13855));
		AddPropertyOverrides("f_siauliai_46_1", MonsterId.Siaulav, Properties("MHP", 256939, "MINPATK", 3805, "MAXPATK", 4578, "MINMATK", 3805, "MAXMATK", 4578, "DEF", 14134, "MDEF", 14134));

		// Monster Spawners --------------------------------

		AddSpawner(MonsterId.Infro_Blud, 30, "SpawnPointCollection1.f_siauliai_46_1", TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner(MonsterId.Shardstatue, 12, "SpawnPointCollection2.f_siauliai_46_1", TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner(MonsterId.Shardstatue, 30, "SpawnPointCollection3.f_siauliai_46_1", TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner(MonsterId.Siaulav, 30, "SpawnPointCollection4.f_siauliai_46_1", TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner(MonsterId.Rootcrystal_01, 13, "SpawnPointCollection5.f_siauliai_46_1", TimeSpan.FromMilliseconds(30000), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Infro_Blud Spawn Points
		AddSpawnPoint("f_siauliai_46_1", Spot(-618.93823, -1133.1177, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-715.7549, -163.08313, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-572.4745, -851.8163, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-441.7074, -448.95612, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-744.2339, -525.3425, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-845.8582, 518.7245, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-602.14734, 507.62512, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-199.54506, 88.906204, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-84.39825, 556.66864, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(138.27307, 613.932, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-257.749, 371.96777, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-579.3384, -1342.9178, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-439.41956, -1305.2369, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-412.28894, -1423.8201, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-282.77902, -1331.9229, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-76.212006, -914.0324, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-202.88545, -873.36975, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-691.3107, 545.36, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-607.9268, 588.5782, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-577.60266, 602.9922, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-638.49817, 647.31433, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-707.63947, 677.5437, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-759.81433, 681.04315, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-790.73645, 625.97485, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-870.0521, 616.36255, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-902.37256, 564.7825, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-906.08813, 494.4172, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-818.31683, 580.6209, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-766.6071, 540.126, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-736.04065, 601.9699, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-674.1005, 466.45676, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-668.58673, 561.448, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-578.75226, 538.1461, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-733.7539, 479.91177, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-689.1493, 624.5983, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-702.82776, 421.6892, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-737.31445, 364.63736, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-779.03064, 334.38223, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-834.4988, 378.71228, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-798.3247, 430.2683, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-753.3637, 431.20898, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-895.42053, 432.5304, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-806.8846, 493.59534, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-894.028, 331.4878, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-855.69525, 264.59546, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-807.6756, 231.28087, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-840.8208, 325.38715, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-705.3511, -225.41196, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-668.41394, -183.43906, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-623.39154, -254.3731, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-678.69775, -322.70148, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-665.69293, -277.64685, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-613.50104, -311.29395, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-566.88995, -307.49167, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-505.9338, -357.9558, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-493.17917, -399.51315, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-415.93646, -399.96555, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-365.37875, -464.54337, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-485.2409, -526.0547, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-339.5464, -402.6613, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-515.10187, -443.6198, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-567.67914, -390.63895, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-546.2152, -365.6359, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-590.9554, -503.53253, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-632.1761, -383.7808, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-690.89355, -475.5703, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-715.4963, -397.5431, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-641.44336, -458.1822, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-619.7723, -574.30963, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-689.0878, -576.77734, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-660.6899, -531.8424, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-651.6709, -653.3571, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-590.6322, -643.2592, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-564.8825, -590.1496, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-523.4705, -585.0845, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-535.626, -666.41266, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-609.7916, -716.8324, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-569.32416, -732.92316, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-552.95886, -792.9143, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-599.2308, -794.8562, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-670.6228, -697.6828, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-551.6875, -491.49716, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-62.73879, 88.54931, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-95.71074, 151.27934, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-159.29982, 204.55637, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-188.02107, 242.15804, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-227.48364, 189.77193, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-257.74536, 161.29636, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-283.93362, 38.673973, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-322.72763, 122.22213, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-254.33212, 73.869415, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-159.66214, 12.553619, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-135.89459, 70.336975, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-175.50856, 145.09927, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-96.207214, 197.83255, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-245.06393, 225.90575, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-265.9174, 306.9728, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-187.05853, 304.2978, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-221.32187, 285.5545, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-190.89828, 343.8294, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-214.66826, 421.73013, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-308.48474, 398.25986, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-301.37762, 153.55894, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-210.01366, 20.175964, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-58.53361, 601.7266, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-65.222694, 640.7398, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-25.598944, 676.4, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-92.285736, 614.8205, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(13.555799, 703.3347, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(62.25818, 716.1583, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(112.50075, 710.7361, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(144.42828, 675.76556, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(99.02538, 645.46674, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(49.709595, 670.18524, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(17.834381, 612.9383, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(102.62816, 567.7396, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(64.461426, 617.295, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-5.587345, 567.42206, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(53.31157, 545.93915, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(139.6718, 534.52435, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(195.01028, 567.55096, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(21.196083, 533.7966, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-559.6914, -1163.3586, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-512.89874, -1180.6082, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-499.99246, -1232.4012, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-513.8717, -1285.3499, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-570.64575, -1270.0508, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-613.5384, -1219.9576, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-607.8225, -1175.3088, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-546.5736, -1219.759, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-545.2836, -1331.8091, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-513.2366, -1412.0687, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-516.05505, -1471.0938, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-451.6258, -1444.0988, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-491.90738, -1379.4, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-586.2213, -1446.0676, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-411.1122, -1346.1149, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-335.9239, -1406.4062, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-353.66116, -1325.6229, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-242.89856, -1367.2229, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-216.00783, -1317.1624, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-302.56537, -1378.0962, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-375.77524, -1376.1768, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-374.82666, -1445.7692, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-446.73608, -1352.3079, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-443.89984, -1387.776, 25), "SpawnPointCollection1.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-479.48468, -1279.961, 25), "SpawnPointCollection1.f_siauliai_46_1");

		// Shardstatue Spawn Points
		AddSpawnPoint("f_siauliai_46_1", Spot(770.9735, -59.051567, 9999), "SpawnPointCollection2.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(528.86597, 452.00854, 9999), "SpawnPointCollection2.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(823.46606, -253.8053, 9999), "SpawnPointCollection2.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(1088.8538, 546.93756, 9999), "SpawnPointCollection2.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(850.83105, 586.58887, 9999), "SpawnPointCollection2.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(630.65607, 726.86676, 9999), "SpawnPointCollection2.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(950.496, 360.20355, 9999), "SpawnPointCollection2.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(1035.4377, -235.45071, 9999), "SpawnPointCollection2.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(774.93774, 414.9102, 9999), "SpawnPointCollection2.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-77.06653, 48.001553, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(610.36127, 680.6599, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(646.9666, 657.097, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(649.3686, 587.31573, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(579.7756, 595.7876, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(495.1881, 595.9707, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(568.30316, 537.8829, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(615.1717, 545.7578, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(533.07874, 634.1434, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(503.46387, 491.8298, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(595.0412, 417.6778, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(450.41812, 525.9925, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(493.65372, 416.82782, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(633.13617, 440.19565, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(700.656, 496.38263, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(722.58215, 561.1544, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(758.6802, 598.676, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(822.9095, 509.14764, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(906.2805, 538.63025, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(890.2261, 632.5185, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(837.9106, 656.87195, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(953.19714, 645.50696, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(1020.5924, 601.0264, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(1071.802, 624.22644, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(1035.9419, 531.0321, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(1144.015, 558.15076, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(1192.4518, 558.0051, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(1242.1912, 547.561, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(1305.2505, 555.9881, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(1217.7584, 642.70105, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(1141.3195, 644.7467, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(1275.988, 660.78076, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(1353.4766, 626.8573, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(1375.6874, 569.54767, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(1334.3246, 602.2291, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(1024.9576, 681.94934, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(978.7084, 552.0453, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(1001.394, 447.3909, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(1009.1795, 375.65057, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(885.6703, 340.76736, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(862.6637, 421.70224, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(936.74695, 428.5583, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(943.8031, 489.6401, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(881.8253, 479.3503, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(800.95496, 572.70184, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(763.3664, 497.31497, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(720.73334, 385.20657, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(772.9974, 357.50867, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(826.2125, 368.13837, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(658.8393, 505.11008, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(508.9103, 553.72046, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(846.008, -83.90661, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(868.8276, -68.99667, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(812.5384, -70.31139, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(1053.6947, -173.81737, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(1115.326, -243.70348, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(1091.9071, -327.63022, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(994.4358, -310.84277, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(950.917, -241.6023, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(882.58203, -255.5554, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(909.09406, -286.31918, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(920.4057, -204.2483, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(991.5243, -197.09811, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(1008.4333, -167.39316, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(999.35205, -264.7202, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(1038.1588, -288.053, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(1027.38, -373.17642, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(1076.9646, -384.0137, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(1026.4376, -418.39197, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(1055.802, -318.28278, 20), "SpawnPointCollection3.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(1078.244, -230.71692, 20), "SpawnPointCollection3.f_siauliai_46_1");

		// Siaulav Spawn Points
		AddSpawnPoint("f_siauliai_46_1", Spot(206.96657, 47.411896, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(220.21808, 305.8052, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(304.04935, -369.55695, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(484.54166, -261.95728, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(346.3715, -813.95966, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(685.72534, -861.2364, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(356.95532, -1040.3553, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(482.8835, -884.8911, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(418.06982, -653.5452, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(575.296, -745.2995, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(197.35632, -899.90326, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-60.097458, -990.1725, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-200.13812, -994.14417, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(292.2597, 333.9693, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(256.30627, 373.23114, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(320.20328, 358.1097, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(367.95905, 306.46225, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(391.23444, 244.91159, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(413.13885, 168.85623, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(385.7937, 77.6358, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(369.5681, 51.55925, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(270.96094, 76.007385, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(270.1088, 201.66388, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(341.29602, 215.38992, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(369.9984, 113.82568, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(320.00885, 106.09736, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(315.70325, 160.57205, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(176.7844, 139.23766, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(118.6692, 246.55264, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(94.12412, 296.24414, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(161.72928, 260.37036, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(145.28151, 180.36917, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(222.2488, 228.6227, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(312.3641, 271.88937, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(268.30096, 274.0783, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(231.27852, 138.21436, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(191.45416, 94.349594, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(186.8178, 198.38824, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(449.17926, -313.36038, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(409.73135, -230.26376, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(446.03766, -227.48566, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(411.86075, -295.82275, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(380.8652, -338.4815, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(337.36475, -287.12463, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(369.77917, -231.08847, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(373.54263, -272.4011, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(318.84814, -214.27945, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(268.59314, -271.15552, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(268.65707, -335.49084, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(294.59714, -304.4677, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(224.23631, -301.44577, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(245.86078, -397.49924, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(275.11664, -458.07074, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(332.33307, -419.9209, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(367.28592, -386.04315, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(375.84662, -460.5271, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(314.76083, -481.77948, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(278.88974, -403.29944, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(470.3668, -683.6126, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(524.5648, -703.8985, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(528.27826, -779.92847, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(622.46545, -741.4355, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(675.56744, -775.2745, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(728.6357, -804.91846, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(746.6609, -871.7134, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(664.8929, -924.4861, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(606.73566, -860.7981, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(587.62787, -951.8357, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(557.15607, -887.21826, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(464.83112, -805.69495, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(399.01962, -720.40967, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(334.672, -718.2165, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(294.02457, -763.88184, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(515.251, -990.3126, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(381.71414, -899.27435, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(398.706, -968.4652, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(461.2292, -953.3483, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(415.23953, -1045.7383, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(287.6867, -1024.6254, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(306.43338, -921.7916, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(337.69135, -974.903, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(277.6878, -860.6044, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(217.54362, -979.30786, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(231.58847, -823.90186, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(317.75195, -878.1848, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(164.10278, -971.24225, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(257.4015, -948.8131, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(241.1883, -1031.0653, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-109.35504, -1022.2288, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-169.10649, -959.4064, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-163.75325, -1040.7068, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-117.91104, -954.9382, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-24.937328, -923.07837, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-72.923904, -859.17114, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-124.74894, -825.2412, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-129.53258, -893.52704, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-238.97517, -933.5192, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-258.8141, -851.0037, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-199.02783, -915.2095, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-175.47835, -821.95166, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-3.9569912, -993.7137, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-69.62767, -1034.9503, 20), "SpawnPointCollection4.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-166.25087, -906.3862, 20), "SpawnPointCollection4.f_siauliai_46_1");

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint("f_siauliai_46_1", Spot(-417.56134, -1358.6265, 150), "SpawnPointCollection5.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-1823.4753, 195.49348, 150), "SpawnPointCollection5.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-571.8378, -453.232, 150), "SpawnPointCollection5.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-766.9431, 541.65015, 150), "SpawnPointCollection5.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(-233.98705, 361.0844, 150), "SpawnPointCollection5.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(81.491486, 618.5661, 150), "SpawnPointCollection5.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(286.32196, 180.45274, 150), "SpawnPointCollection5.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(307.28467, -365.6086, 150), "SpawnPointCollection5.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(437.2024, -866.3833, 150), "SpawnPointCollection5.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(1024.3563, -273.85416, 150), "SpawnPointCollection5.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(588.62604, 497.37982, 150), "SpawnPointCollection5.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(756.3257, 1104.9958, 150), "SpawnPointCollection5.f_siauliai_46_1");
		AddSpawnPoint("f_siauliai_46_1", Spot(1037.2891, 511.26166, 150), "SpawnPointCollection5.f_siauliai_46_1");

	}
}
