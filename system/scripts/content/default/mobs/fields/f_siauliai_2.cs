//--- Melia Script -----------------------------------------------------------
// f_siauliai_2
//
//--- Description -----------------------------------------------------------
// Sets up the f_siauliai_2 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using static Melia.Zone.Scripting.Shortcuts;

public class FSiauliai2MobScript : GeneralScript
{
	public override void Load()
	{
		// Property Overrides
		AddPropertyOverrides("f_siauliai_2", MonsterId.Chupacabra_Blue, Properties("MHP", 1786, "MINPATK", 164, "MAXPATK", 176, "MINMATK", 164, "MAXMATK", 176, "DEF", 15, "MDEF", 15));
		AddPropertyOverrides("f_siauliai_2", MonsterId.Pokubu, Properties("MHP", 2256, "MINPATK", 185, "MAXPATK", 199, "MINMATK", 185, "MAXMATK", 199, "DEF", 18, "MDEF", 18));
		AddPropertyOverrides("f_siauliai_2", MonsterId.Weaver, Properties("MHP", 2515, "MINPATK", 197, "MAXPATK", 212, "MINMATK", 197, "MAXMATK", 212, "DEF", 19, "MDEF", 19));
		AddPropertyOverrides("f_siauliai_2", MonsterId.Popolion_Blue, Properties("MHP", 2013, "MINPATK", 174, "MAXPATK", 187, "MINMATK", 174, "MAXMATK", 187, "DEF", 16, "MDEF", 16));

		// Monster Spawners --------------------------------

		AddSpawner(MonsterId.Chupacabra_Blue, 20, TimeSpan.FromMilliseconds(0), "Spawner1.f_siauliai_2");
		AddSpawner(MonsterId.Pokubu, 8, TimeSpan.FromMilliseconds(0), "Spawner2.f_siauliai_2");
		AddSpawner(MonsterId.Rootcrystal_01, 17, TimeSpan.FromMilliseconds(30000), "Spawner3.f_siauliai_2");
		AddSpawner(MonsterId.Weaver, 20, TimeSpan.FromMilliseconds(0), "Spawner4.f_siauliai_2");
		AddSpawner(MonsterId.Popolion_Blue, 60, TimeSpan.FromMilliseconds(0), "Spawner5.f_siauliai_2");
		AddSpawner(MonsterId.Popolion_Blue, 10, TimeSpan.FromMilliseconds(0), "Spawner6.f_siauliai_2");
		AddSpawner(MonsterId.Chupacabra_Blue, 6, TimeSpan.FromMilliseconds(0), "Spawner7.f_siauliai_2");
		AddSpawner(MonsterId.Chupacabra_Blue, 30, TimeSpan.FromMilliseconds(0), "Spawner8.f_siauliai_2");
		AddSpawner(MonsterId.Popolion_Blue, 30, TimeSpan.FromMilliseconds(0), "Spawner9.f_siauliai_2");
		AddSpawner(MonsterId.Popolion_Blue, 10, TimeSpan.FromMilliseconds(0), "Spawner10.f_siauliai_2");

		// Monster Spawn Points -----------------------------

		// Chupacabra_Blue Spawn Points
		AddSpawnPoint("f_siauliai_2", Spot(-1415.4171, -371.55478, 30), "Spawner1.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-965.8191, 31.569534, 30), "Spawner1.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1100.5059, 111.37015, 30), "Spawner1.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-231.61755, 85.811066, 30), "Spawner1.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-170, -154, 30), "Spawner1.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-262.82687, 422.1841, 30), "Spawner1.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-539.0047, -29.294334, 30), "Spawner1.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1002.7767, 586.3515, 30), "Spawner1.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(171.14359, 1082.8328, 30), "Spawner1.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(296.45502, 1122.743, 30), "Spawner1.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(560, 690, 30), "Spawner1.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(429, -680, 30), "Spawner1.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(165, -547, 30), "Spawner1.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(260, -658, 30), "Spawner1.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(388, -271, 30), "Spawner1.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(163, -282, 30), "Spawner1.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(421, -420, 30), "Spawner1.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-919.7093, 931.91504, 30), "Spawner1.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-460, 1113, 30), "Spawner1.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-291, 907, 30), "Spawner1.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-254, 1148, 30), "Spawner1.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-860.30164, 568.4828, 30), "Spawner1.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-993.1989, 776.5989, 30), "Spawner1.f_siauliai_2");

		// Pokubu Spawn Points
		AddSpawnPoint("f_siauliai_2", Spot(2074.0327, 129.61322, 30), "Spawner2.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(1976.7208, 171.50061, 30), "Spawner2.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(2171, 90, 30), "Spawner2.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(2135, 336, 30), "Spawner2.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(2017.9362, 276.1759, 30), "Spawner2.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(2130, -95, 30), "Spawner2.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(1885, 288, 30), "Spawner2.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(1818.9464, 184.72943, 30), "Spawner2.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(2038.9165, 381.7809, 30), "Spawner2.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(2095.055, 23.893608, 30), "Spawner2.f_siauliai_2");

		// Rootcrystal_01 Spawn Points
		AddSpawnPoint("f_siauliai_2", Spot(-1110, 26, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-825, 63, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-873, 284, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-907, 927, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1002, 842, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-899, 691, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1832, 736, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1891, 1003, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-2162, 894, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-2298, 1140, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-284, 824, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(514, 318, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(445, 1075, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(275, 1086, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-90, -284, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-154, 77, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-96, -821, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(231, -569, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(2030, -428, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(2054, 150, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(1720, 1033, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(2206, 1118, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1932, -988, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-660, -762, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-967, -809, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1456, -395, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1180, -278, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1225, 138, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-950, 78, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1081, 238, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1029, 350, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1005, 616, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1184, 905, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1449, 808, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1519, 618, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1698, 786, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1779, 614, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-2230, 846, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-2342, 1074, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-2147, 1227, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-2123, 1365, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-2173, 1607, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-2439, 1592, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-679, 229, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-488, -35, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-316, 185, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-177, -332, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-50, 41, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-87, 217, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-249, 322, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-276, 528, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-434, 683, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-771, 1137, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-650, 1155, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-672, 1023, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-323, 1184, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-413, 998, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-232, 959, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(37, 1257, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(32, 1078, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1323.5741, -236.76746, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(566, 871, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(586, 751, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(646, 542, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(543, 496, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(936, 269, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(678, 104, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(693.9263, -41.317894, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(371.82144, -311.6812, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(351, -399, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(154, -392, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(423, -656, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(636, -611, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(635, -830, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(480, -963, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(843, -798, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(772, -954, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(1305, 565, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(1390, 837, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(1873, 1044, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(1999, 1144, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(1537, 200, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(1706, 208, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(2022, 319, 100), "Spawner3.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(2046, -1, 100), "Spawner3.f_siauliai_2");

		// Weaver Spawn Points
		AddSpawnPoint("f_siauliai_2", Spot(181.55257, -673.93396, 40), "Spawner4.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-37.895172, -764.7075, 40), "Spawner4.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-137, -871, 40), "Spawner4.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(268.08817, -524.2529, 40), "Spawner4.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(143.56892, -573.7747, 40), "Spawner4.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-203, -636, 40), "Spawner4.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-131.708, -378.45108, 40), "Spawner4.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(618, -921, 40), "Spawner4.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(654, -833, 40), "Spawner4.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(854, -798, 40), "Spawner4.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(831, -882, 40), "Spawner4.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(1446, 952, 40), "Spawner4.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(1939, 174, 40), "Spawner4.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(1847, 294, 40), "Spawner4.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(2030.6299, 369.79553, 40), "Spawner4.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(1596.8788, 222.25282, 40), "Spawner4.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(1518.1165, 205.74327, 40), "Spawner4.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(1657.2533, 95.505554, 40), "Spawner4.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(1554, 130, 40), "Spawner4.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(1732, 150, 40), "Spawner4.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(1376.0139, 761.81067, 40), "Spawner4.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(1273.9951, 586.33527, 40), "Spawner4.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(1343.0482, 525.35785, 40), "Spawner4.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(1296.2782, 685.33264, 40), "Spawner4.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(1299.6434, 797.14, 40), "Spawner4.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(1466, 847, 40), "Spawner4.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(1508, 896, 40), "Spawner4.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(712, -895, 40), "Spawner4.f_siauliai_2");

		// Popolion_Blue Spawn Points
		AddSpawnPoint("f_siauliai_2", Spot(-1927.1439, 1041.3624, 9999), "Spawner5.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-2368.3542, 1278.7267, 30), "Spawner6.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1840.894, 742.63513, 30), "Spawner6.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-2149.215, 831.1933, 30), "Spawner6.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1765, 595, 30), "Spawner6.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1985.55, 1064.5444, 30), "Spawner6.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1892, 955, 30), "Spawner6.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-2227.6328, 1089.1436, 30), "Spawner6.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-994.88434, 498.73575, 30), "Spawner6.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-843.18036, 559.9528, 30), "Spawner6.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-915.6565, 744.29175, 30), "Spawner6.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1990.8632, -1187.754, 30), "Spawner6.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1971.9531, -1430.1814, 30), "Spawner6.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1887.691, -1060.5604, 30), "Spawner6.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1947.2255, -1337.2001, 30), "Spawner6.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1985.9625, -1047.5697, 30), "Spawner6.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-796.8218, -1168.5641, 30), "Spawner6.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-987.0851, -1443.2349, 30), "Spawner6.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-835.3502, -843.40186, 30), "Spawner6.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1046.309, -1249.9479, 30), "Spawner6.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1122.596, -1559.5442, 30), "Spawner6.f_siauliai_2");

		// Chupacabra_Blue Spawn Points
		AddSpawnPoint("f_siauliai_2", Spot(258.80804, -563.19403, 250), "Spawner7.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-2010.5305, -971.0856, 50), "Spawner8.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1917.9153, -961.36273, 50), "Spawner8.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1992.7848, -1328.6621, 50), "Spawner8.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1821.18, -1165.9307, 50), "Spawner8.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-429.78116, 587.1281, 50), "Spawner8.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1813.9086, -1480.6727, 50), "Spawner8.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1881.3862, -1546.1348, 50), "Spawner8.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1625.9272, -1464.0221, 50), "Spawner8.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1311.7227, -1471.2858, 50), "Spawner8.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1263.4482, -1573.5892, 50), "Spawner8.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1159.3401, -1391.4847, 50), "Spawner8.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1063.2109, -1490.6077, 50), "Spawner8.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-913.03, -1266.498, 50), "Spawner8.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1005.0578, -1164.5784, 50), "Spawner8.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-959.2174, -1426.8529, 50), "Spawner8.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-755.62164, -969.85876, 50), "Spawner8.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-880.12445, -865.8571, 50), "Spawner8.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-713.44916, 1020.9352, 50), "Spawner8.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-602.8175, 600.1465, 50), "Spawner8.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1921.7312, -1180.6476, 50), "Spawner8.f_siauliai_2");

		// Popolion_Blue Spawn Points
		AddSpawnPoint("f_siauliai_2", Spot(-1971.7739, -1078.5951, 40), "Spawner9.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1982.229, -1326.2974, 40), "Spawner9.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1837.6208, -1238.417, 40), "Spawner9.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1839.5162, -1439.9487, 40), "Spawner9.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1958.9437, -1474.009, 40), "Spawner9.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1601.8713, -1459.9364, 40), "Spawner9.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1339.1614, -1495.0128, 40), "Spawner9.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1202.0392, -1398.2892, 40), "Spawner9.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1029.8602, -1521.7524, 40), "Spawner9.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-877.6972, -1165.6431, 40), "Spawner9.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1040.0602, -1230.8342, 40), "Spawner9.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-886.7796, -1345.2092, 40), "Spawner9.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-835.0664, -899.12335, 40), "Spawner9.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-943.9983, -956.24524, 40), "Spawner9.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-959.87305, -1256.3824, 40), "Spawner9.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1108.8827, -1581.1145, 40), "Spawner9.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-690.60876, -1000.6702, 40), "Spawner9.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-1941.5376, -1188.4371, 40), "Spawner9.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-391.65002, 1104.015, 300), "Spawner10.f_siauliai_2");
		AddSpawnPoint("f_siauliai_2", Spot(-772.93024, 1040.5347, 300), "Spawner10.f_siauliai_2");

	}
}
