//--- Melia Script -----------------------------------------------------------
// f_tableland_28_1
//
//--- Description -----------------------------------------------------------
// Sets up the f_tableland_28_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class FTableland281MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner(MonsterId.Rootcrystal_03, 13, "SpawnPointCollection1.f_tableland_28_1", TimeSpan.FromMilliseconds(5000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Repusbunny_Green, 150, "SpawnPointCollection2.f_tableland_28_1", TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner(MonsterId.Repusbunny_Bow_Green, 25, "SpawnPointCollection3.f_tableland_28_1", TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner(MonsterId.Saltisdaughter_Mage_Red, 20, "SpawnPointCollection4.f_tableland_28_1", TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_03 Spawn Points
		AddSpawnPoint("f_tableland_28_1", Spot(2.8408165, -524.4103, 50), "SpawnPointCollection1.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1219.5177, -609.0739, 50), "SpawnPointCollection1.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1528.8616, -431.62653, 50), "SpawnPointCollection1.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(2020.2548, -107.01742, 50), "SpawnPointCollection1.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(2257.6274, 205.06879, 50), "SpawnPointCollection1.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1937.7372, 599.0522, 50), "SpawnPointCollection1.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(678.7784, -17.683138, 50), "SpawnPointCollection1.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(710.7136, 308.31, 50), "SpawnPointCollection1.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(327.10114, 236.63885, 50), "SpawnPointCollection1.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-128.66335, 231.04144, 50), "SpawnPointCollection1.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-442.2072, 387.33026, 50), "SpawnPointCollection1.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-681.9301, 616.0018, 50), "SpawnPointCollection1.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-969.0644, 699.4119, 50), "SpawnPointCollection1.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1257.2817, 165.16887, 50), "SpawnPointCollection1.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-758.89966, 1081.2393, 50), "SpawnPointCollection1.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-778.1956, 1483.7043, 50), "SpawnPointCollection1.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1712.9126, 602.97546, 50), "SpawnPointCollection1.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1710.518, 1105.2148, 50), "SpawnPointCollection1.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1431.2659, 1313.1316, 50), "SpawnPointCollection1.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-2195.3308, 1317.9509, 50), "SpawnPointCollection1.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-2819.582, 1055.2588, 50), "SpawnPointCollection1.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-3211.1855, 885.409, 50), "SpawnPointCollection1.f_tableland_28_1");

		// Repusbunny_Green Spawn Points
		AddSpawnPoint("f_tableland_28_1", Spot(1963.7229, 537.7066, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1758.809, -184.439, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1141.5172, -640.88727, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1421.177, -366.09714, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(546.41754, 289.47305, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(803.4686, 129.58688, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(502.46167, 392.23074, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-616.70776, 557.8091, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-334.54755, 298.13474, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(10.397789, 234.33116, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1329.8936, -37.470863, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1762.3063, -195.50963, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1294.8119, -361.71524, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1529.4573, 124.42268, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-903.7919, 464.91107, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1047.9271, 650.68646, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-809.7748, 1044.1924, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1681.7468, 1247.855, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1290.1086, 1388.4998, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1785.469, 971.5759, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-3125.868, 1089.8477, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1548.4364, 1394.6985, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-3030.5732, 1193.8129, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-3258.9937, 1075.5364, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-2594.5151, 1261.68, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-2357.7583, 1307.4285, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-2053.926, 1356.6731, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1372.5708, -812.2434, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1514.2988, -914.4249, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1634.2893, -881.4205, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1749.1876, -801.9437, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1792.4288, -681.7198, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1717.2618, -541.2407, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1656.6268, -705.6877, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1415.2383, -525.23035, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1612.2424, -417.9924, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1562.7926, -547.5047, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1567.0488, -784.8697, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1409.3224, -688.23987, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1245.2316, -714.9796, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1274.4249, -562.40283, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1271.5527, -850.96265, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1142.4681, -800.92816, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1058.6809, -698.00684, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1066.2433, -507.93832, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1032.706, -380.8767, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1124.512, -288.581, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1253.0404, -230.38913, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1183.4967, -411.0204, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1439.8335, -207.7306, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1608.0903, -219.112, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1286.7753, -341.32385, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1715.987, -354.97604, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1894.5792, -119.24091, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1962.6256, -98.35873, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1958.053, -179.64558, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(2012.9758, -225.37442, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(2025.8888, -141.38785, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(2021.1482, -60.157543, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(2073.1267, -178.1559, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(2038.9911, 477.03125, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(2102.5823, 396.52844, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(2200.3171, 269.47998, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1715.0981, 939.253, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1703.9856, 863.8276, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1665.2977, 957.0629, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1651.8887, 853.86554, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1664.956, 808.3073, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1712.7781, 795.4717, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1757.9597, 824.3064, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1773.8457, 768.1574, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1808.2955, 711.32776, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-4.9174423, -598.1028, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-70.24279, -643.77905, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-166.08156, -667.12225, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-162.9632, -535.62177, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-21.081188, -477.2313, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(99.91028, -305.79117, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(101.20545, -552.1197, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(54.712387, -417.9796, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(23.92543, -733.6414, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(134.35774, -629.5175, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-172.8933, -436.54974, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-65.80178, -367.3063, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(171.93, -429.04968, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(741.1831, -110.16203, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(779.8899, 41.181343, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(831.66693, -56.839424, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(916.5097, 72.24783, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(930.0251, 190.22337, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(825.7781, 203.82831, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(803.4954, 274.62994, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(761.865, 320.56665, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(698.4779, 357.44815, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(368.96402, 307.96692, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(397.976, 191.30359, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(630.57086, 287.8582, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(681.5489, 249.64093, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(715.3935, 68.7173, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(694.1545, 133.57199, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(610.15204, 113.82064, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(630.8845, 20.689224, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(540.7711, 137.6132, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(537.66595, 22.484417, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(698.94464, -29.003809, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(484.63077, 240.16885, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(625.19434, -106.06828, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(471.503, -37.024597, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(371.08115, 20.902878, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(454.7123, 52.57748, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(296.75232, 199.64795, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(346.6972, 108.98679, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-248.76329, 249.0611, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-286.87378, 314.60876, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-367.6957, 329.33493, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-412.78134, 345.42844, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-442.7754, 375.74097, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-483.41983, 368.29626, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-459.85452, 414.75168, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-502.5123, 408.98383, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-565.10535, 478.27432, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-601.5274, 511.83945, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-944.24585, 691.12, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-931.35187, 589.1134, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-771.3383, 666.48676, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-677.6879, 622.9343, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-820.3416, 785.6165, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-763.34973, 1285.6703, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-688.8919, 1085.7676, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-693.6817, 1179.0905, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-914.90204, 851.2685, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-962.4303, 785.87506, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1007.714, 420.9937, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1048.2303, 489.6304, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1064.6812, 556.10266, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-823.8863, 559.6887, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1841.9147, 473.96136, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1228.6599, 655.82654, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1367.5376, 656.41113, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1292.3727, 614.74725, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1347.9618, 592.12866, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1415.6101, 611.245, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1425.4728, 688.354, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1601.2291, 632.0996, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1607.4061, 525.0739, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1891.9865, 602.4464, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1748.0155, 774.38257, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1756.3093, 441.1571, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1659.6664, 445.83948, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1715.9062, 513.1545, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1622.716, 753.8743, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1960.912, 553.3747, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1759.3241, 642.2764, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1996.7029, 665.4455, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1898.7565, 782.4315, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1890.2098, 858.5427, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1839.9963, 677.36755, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1834.5769, 785.1056, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1726.3583, 1006.7147, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1815.3987, 1035.2812, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1671.8082, 1051.5219, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1709.0289, 1176.0063, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1466.338, 1149.5061, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1626.4349, 1219.1504, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1369.0414, 1265.8625, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1609.1605, 1303.8091, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1761.8834, 1315.565, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1744.7252, 1264.2054, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1678.3536, 1316.0455, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1816.9945, 1381.3258, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1741.7339, 1378.1368, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1652.2417, 1368.1816, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1593.6675, 1391.6636, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1418.5059, 1375.0219, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1357.6576, 1137.4973, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1248.4183, 1237.4089, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1381.8152, 1484.4087, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1486.7922, 1254.3618, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1826.1975, 1325.8721, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1875.0951, 1358.8074, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1947.1533, 1356.342, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-2010.5521, 1355.1938, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-2109.6418, 1347.1094, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-2158.6187, 1337.4937, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-2404.0552, 1247.936, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-2294.421, 1312.6201, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-2553.9766, 1184.5541, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-2650.4707, 1203.0962, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-2789.5098, 1043.1688, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-2867.0732, 1130.4045, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-3086.3433, 996.8286, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-3245.0986, 826.1572, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-3068.1497, 890.41077, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-3349.6138, 973.85535, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-3380.0623, 835.0604, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-2991.7432, 823.3338, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-2969.5305, 1089.4701, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-2941.232, 953.50775, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-2806.57, 977.8125, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-2853.0745, 904.79266, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-3090.2327, 773.6434, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-3209.5874, 950.7618, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-2907.095, 733.8213, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-3160.334, 683.23254, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-3305.6797, 697.62836, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1547.7715, 47.127335, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1633.998, 72.332794, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1605.924, -64.57368, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1612.7029, 201.73431, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1760.5461, 133.74829, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1697.4783, -84.428185, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1653.0258, -200.12703, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1830.8038, -28.841492, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1508.8357, -93.8628, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1470.3339, 8.975389, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1382.806, -124.53481, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1451.0323, -191.13214, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1229.1382, -139.66505, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1273.5073, 255.23343, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1392.1522, 61.521183, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1471.1974, 219.67377, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1360.1738, 259.09476, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1273.1461, 120.22259, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1163.1133, 63.197227, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1112.6571, -67.51372, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1105.2427, 9.6751, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1170.1383, -73.7283, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1109.3888, -212.51418, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1070.5961, -132.7198, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1239.8583, -206.93228, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1167.38, -321.94727, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1355.152, -202.72914, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1257.1421, -294.17184, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1468.8673, -270.68317, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1414.2588, -375.38873, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1523.2799, -359.96863, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1367.8212, -291.29562, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1629.0082, -372.22333, 25), "SpawnPointCollection2.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1721.6284, -359.6094, 25), "SpawnPointCollection2.f_tableland_28_1");

		// Repusbunny_Bow_Green Spawn Points
		AddSpawnPoint("f_tableland_28_1", Spot(-1383.2535, -129.48665, 25), "SpawnPointCollection3.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1331.3939, 208.2179, 25), "SpawnPointCollection3.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1164.5509, -9.234051, 25), "SpawnPointCollection3.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1622.4304, -231.07948, 25), "SpawnPointCollection3.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1666.1749, 141.77182, 25), "SpawnPointCollection3.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1130.678, 394.33942, 25), "SpawnPointCollection3.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-2906.6462, 1064.8467, 25), "SpawnPointCollection3.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-2208.072, 1345.5255, 25), "SpawnPointCollection3.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1764.7778, 990.31024, 25), "SpawnPointCollection3.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-867.4383, 637.9898, 25), "SpawnPointCollection3.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1534.2758, 1249.3677, 25), "SpawnPointCollection3.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1829.462, 779.4019, 25), "SpawnPointCollection3.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1707.7677, 579.93665, 25), "SpawnPointCollection3.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1344.1188, 711.3946, 25), "SpawnPointCollection3.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-851.1938, 837.8529, 25), "SpawnPointCollection3.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1367.1448, 1426.221, 25), "SpawnPointCollection3.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-1779.3336, -6.9213676, 25), "SpawnPointCollection3.f_tableland_28_1");

		// Saltisdaughter_Mage_Red Spawn Points
		AddSpawnPoint("f_tableland_28_1", Spot(2163.7163, 328.27695, 25), "SpawnPointCollection4.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-126.30708, -520.05225, 25), "SpawnPointCollection4.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(577.275, 28.748514, 25), "SpawnPointCollection4.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(406.60297, 264.10382, 25), "SpawnPointCollection4.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(745.263, 253.6511, 25), "SpawnPointCollection4.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1173.8237, -558.18744, 25), "SpawnPointCollection4.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1431.5873, -291.19574, 25), "SpawnPointCollection4.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1533.4487, -692.98584, 25), "SpawnPointCollection4.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1607.6062, -481.5982, 25), "SpawnPointCollection4.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(2103.3564, -70.27001, 25), "SpawnPointCollection4.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1802.4371, 905.61053, 25), "SpawnPointCollection4.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-520.30664, 450.63974, 25), "SpawnPointCollection4.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(-295.16144, 264.44507, 25), "SpawnPointCollection4.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(170.63567, 256.92734, 25), "SpawnPointCollection4.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(2.0256157, -641.7832, 25), "SpawnPointCollection4.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1407.174, -546.8157, 25), "SpawnPointCollection4.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1822.2477, -176.13992, 25), "SpawnPointCollection4.f_tableland_28_1");
		AddSpawnPoint("f_tableland_28_1", Spot(1739.2124, 737.2787, 25), "SpawnPointCollection4.f_tableland_28_1");

	}
}
