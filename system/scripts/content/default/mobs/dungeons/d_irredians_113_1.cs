//--- Melia Script -----------------------------------------------------------
// d_irredians_113_1
//
//--- Description -----------------------------------------------------------
// Sets up the d_irredians_113_1 mobs.
//---------------------------------------------------------------------------

using System;
using Melia.Zone.Scripting;
using Melia.Shared.Tos.Const;
using static Melia.Zone.Scripting.Shortcuts;

public class DIrredians1131MobScript : GeneralScript
{
	public override void Load()
	{

		// Monster Spawners --------------------------------

		AddSpawner(MonsterId.Rootcrystal_03, 30, "SpawnPointCollection1.d_irredians_113_1", TimeSpan.FromMilliseconds(20000), TendencyType.Peaceful);
		AddSpawner(MonsterId.Gazer, 85, "SpawnPointCollection2.d_irredians_113_1", TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner(MonsterId.Maskexecutor, 85, "SpawnPointCollection3.d_irredians_113_1", TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner(MonsterId.Greedyprisoner, 40, "SpawnPointCollection4.d_irredians_113_1", TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);
		AddSpawner(MonsterId.PuppetM, 73, "SpawnPointCollection5.d_irredians_113_1", TimeSpan.FromMilliseconds(0), TendencyType.Peaceful);

		// Monster Spawn Points -----------------------------

		// Rootcrystal_03 Spawn Points
		AddSpawnPoint("d_irredians_113_1", Spot(-357.28622, -1094.2461, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-285.62836, -932.0164, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-212.48494, -500.8076, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(161.21266, -713.27515, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(551.3353, -622.2208, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(591.80585, -161.93352, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(573.33356, 238.2361, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(574.4321, 632.41925, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(496.9265, 1017.1646, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(84.6738, 1045.8314, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-262.0603, 1037.7211, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-681.39655, 1033.7316, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-662.21545, 585.9053, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-657.18604, 188.80264, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-660.4651, -155.974, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-651.80383, -517.36896, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1144.5543, -868.6093, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1240.1636, -572.0074, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-962.6876, -636.98035, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1404.2069, -142.0704, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1092.2222, -16.16286, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-788.7767, -70.34663, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-995.51025, 353.45227, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1173.9333, 660.3163, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-872.1206, 601.43713, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(938.53046, 664.11334, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1292.1522, 644.9285, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1115.9994, 477.37784, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1591.6771, 197.56808, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1338.1007, 77.680626, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1025.0253, 200.25005, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(827.3408, 65.295334, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(936.67035, -498.15332, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(992.48267, -216.26552, 200), "SpawnPointCollection1.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1291.1969, -422.551, 200), "SpawnPointCollection1.d_irredians_113_1");

		// Gazer Spawn Points
		AddSpawnPoint("d_irredians_113_1", Spot(-1225.6615, -558.1624, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1125.7809, -533.89233, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1029.6844, -577.9976, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1233.6185, -690.6044, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1199.6475, -794.0828, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1130.6273, -869.23596, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-987.4168, -859.4532, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-941.9008, -752.59393, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1430.9968, -140.34726, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1357.3632, -162.42415, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1285.6847, -129.96376, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1437.5337, 4.7409544, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1385.1141, 56.144424, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1301.5076, 18.583157, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1099.2126, 737.1395, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1035.4025, 806.3371, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-920.8721, 761.6961, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1097.0526, 452.34503, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1161.7375, 521.7909, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1157.3588, 624.4117, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-849.6826, 450.22214, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-819.9607, 529.93054, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-834.8898, 641.9332, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-520.46436, -546.9584, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-585.0693, -524.761, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-631.1182, -435.8559, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(509.95596, -587.9317, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(587.9726, -570.50415, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(603.0717, -470.05722, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(507.4952, 948.80035, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(590.579, 913.7645, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(629.8627, 776.6585, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-603.3522, 856.67773, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-635.24036, 1010.7428, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-485.09735, 951.09424, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(133.53319, -813.4881, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(221.12102, -773.611, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(262.86896, -684.069, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(492.12476, -702.5082, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(563.34534, -684.07355, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(640.5711, -637.9272, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-255.93196, -514.12665, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-262.9592, -436.2279, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-176.26726, -445.1519, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-551.2841, -466.6133, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-559.0205, -404.70187, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-641.0676, -370.22067, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-639.2238, 120.23142, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-525.0012, 201.71602, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-613.03906, 285.1083, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(542.0767, 105.77231, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(628.48126, 150.0076, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(549.7817, 238.90924, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-5.478634, 927.7534, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-78.85144, 999.7373, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(140.70312, 974.04785, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-879.8099, -217.46162, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-815.2869, -201.72229, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-834.774, 32.49843, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-556.92725, -347.38034, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1007.9064, -160.01315, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-932.82684, -21.595175, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1021.257, 53.743374, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-618.2657, -172.59647, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-544.9272, -87.312996, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-647.0962, 487.47162, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-612.01825, 679.1025, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-545.751, 326.35464, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-538.5297, 82.69843, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-255.71785, 906.81055, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-196.41539, 893.4147, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(328.48862, 969.3359, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(377.71695, 981.0655, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(569.69366, 553.1284, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(589.02826, 465.60928, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(568.53613, -305.59268, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(553.5922, -233.37804, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-993.4526, 485.27606, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-921.9293, 521.1514, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-163.60622, -547.5368, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-212.91289, -605.8226, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(41.942223, -803.49194, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(235.21545, -548.7112, 20), "SpawnPointCollection2.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-875.9196, 664.73706, 20), "SpawnPointCollection2.d_irredians_113_1");

		// Maskexecutor Spawn Points
		AddSpawnPoint("d_irredians_113_1", Spot(-1152.3169, -676.2056, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1093.7599, -637.9011, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1027.3395, -678.0992, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1134.0037, -755.50287, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1077.6694, -811.9372, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1026.8383, -788.10266, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-988.6753, -169.77174, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-902.64374, -166.02814, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-861.46094, -107.76201, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-873.6664, -27.870913, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-926.0642, 34.89247, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1026.7914, 44.284847, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1019.2405, 505.76733, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1068.6991, 582.1871, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1021.5455, 662.101, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-929.79987, 690.2923, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-900.4318, 613.54156, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-925.75476, 519.35925, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-160.9384, -652.6311, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-187.5404, -584.23254, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-145.89154, -538.5514, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-242.53021, -625.9638, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(56.08796, -724.14844, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(124.68288, -707.1921, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(157.3908, -654.29047, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(138.38303, -556.72516, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(223.8201, -624.7354, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(215.80919, -482.87955, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-640.1886, -278.2983, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-565.4478, -331.012, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-536.1217, -259.36005, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-644.80035, 0.9333782, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-567.82855, 54.537445, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-543.17145, 326.0663, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-647.61597, 360.44672, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-645.6309, 767.04065, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-558.8755, 774.3358, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-569.3906, 942.71027, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-387.81436, 889.1347, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-398.49197, 988.3705, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-68.90451, 894.7454, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(11.786585, 1000.1122, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(92.83011, 877.34686, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(519.40686, 878.2899, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(550.3734, 785.30585, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(644.9086, 702.0683, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(433.81934, 973.1461, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(537.23596, 175.78987, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(622.7158, 28.187235, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(622.8353, 282.00485, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(448.37793, -577.9426, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(366.05048, -602.66077, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(551.7867, -505.79077, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(617.68604, -402.30093, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-93.64888, -612.3327, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(79.83177, -628.42664, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1301.5002, -650.01074, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1266.246, -761.4615, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1242.2556, -847.23376, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1224.4819, 631.11206, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1317.7383, -130.77718, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1315.7253, -4.403389, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-809.92755, -258.53815, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-826.47473, 70.76433, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1077.5066, -95.82493, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1038.8146, -8.927538, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1121.3269, 545.36743, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1119.8325, 683.24713, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-979.64716, 587.5658, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1009.9266, 748.6085, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-79.91163, -525.7353, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(22.353699, -503.3022, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-8.588219, -721.93713, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-86.26277, -677.76227, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(584.0619, -301.70255, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(518.96246, -182.53943, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(651.3462, 467.42676, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(569.87885, 464.52396, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(375.69043, 900.121, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(306.69873, 1007.8155, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-245.74266, 896.9205, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-240.8511, 1013.4349, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1077.9667, 775.0632, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1056.264, 855.8826, 20), "SpawnPointCollection3.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-937.4481, 781.0037, 20), "SpawnPointCollection3.d_irredians_113_1");

		// Greedyprisoner Spawn Points
		AddSpawnPoint("d_irredians_113_1", Spot(-1133.258, -13.696632, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-968.4251, -64.21874, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1226.026, -623.5912, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1071.165, -727.1482, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-60.95077, -555.20154, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(66.10991, -530.4668, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-18.858198, -683.3673, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-975.4767, 569.45984, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-1091.0042, 523.92505, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-994.08905, 732.76086, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-635.45026, -173.79459, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-564.0366, -82.55908, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-621.227, 492.18906, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-566.5616, 582.0868, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-217.18085, 910.51337, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(-167.20094, 993.38794, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(249.3884, 984.0353, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(321.64832, 908.59845, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(530.4175, 600.048, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(616.8894, 445.24765, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(532.2211, -39.70718, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(597.41876, -141.83185, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(905.0637, -402.14563, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(990.6959, -523.4624, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(974.90564, -304.93405, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(925.8241, 96.34309, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1038.7059, 42.206345, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1089.8358, 117.58879, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(938.84515, 670.12573, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1031.6724, 503.993, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1290.3613, 531.60223, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1317.5009, 705.52106, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1077.9187, 577.8534, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1212.772, 601.28564, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1338.8284, 99.125046, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1481.5967, 0.8801689, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1546.2035, 191.06784, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1175.8972, -511.82657, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1256.889, -410.71988, 20), "SpawnPointCollection4.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1210.3461, -318.92862, 20), "SpawnPointCollection4.d_irredians_113_1");

		// PuppetM Spawn Points
		AddSpawnPoint("d_irredians_113_1", Spot(1008.6226, -389.5508, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1026.1627, -360.28766, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1053.9272, -329.03015, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1093.5613, -477.11945, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1120.7485, -452.96677, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1152.6361, -431.72073, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1064.9408, -176.65663, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1111.7192, -167.8902, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1144.6521, -209.44966, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1309.0693, -359.90118, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1334.1444, -417.00198, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1357.2361, -375.45602, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(870.6979, -478.7719, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(886.6209, -516.37366, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(933.4794, -541.68335, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1153.4224, -359.81302, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1130.981, -311.16412, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1086.6119, -270.45978, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(895.0835, -291.6408, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(922.5262, -225.65004, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1391.2098, 60.23676, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1428.3464, 27.801582, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1378.6633, 177.42488, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1415.9407, 207.46274, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1524.2004, 50.225323, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1528.4427, 99.1841, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(875.15546, 45.193386, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(830.47894, 123.45976, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(953.5859, 39.03422, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1112.9226, 33.17036, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1129.2986, 87.272026, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1168.2152, 135.07372, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1126.5387, 183.81874, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1025.8018, 230.36124, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(990.0762, 146.96106, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(892.57324, 649.42084, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(875.9891, 731.02515, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(956.1034, 712.12463, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(971.37, 503.1505, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1038.4167, 443.79645, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1090.702, 475.70062, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1024.3917, 593.9968, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1109.9185, 518.4149, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1131.8392, 584.998, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1181.3619, 551.1137, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1243.753, 540.5908, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1252.878, 627.8824, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1320.7808, 568.36597, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1254.8678, 467.39932, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1334.6432, 459.94882, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1238.2526, 750.678, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1302.7017, 648.9261, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1369.8079, 719.1246, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1016.4017, -237.16139, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1090.0825, -400.28088, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1046.4216, -524.6, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(947.37396, -468.325, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1142.4165, -570.2276, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1276.5123, -471.2577, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(977.27014, -183.07855, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(918.5781, 110.47623, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1561.0306, 207.76166, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1613.2305, 132.81227, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(906.5349, 545.8729, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(837.93207, 634.7156, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(831.6678, 706.8586, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1339.3231, 806.964, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1044.6492, 61.773766, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1391.9086, -10.786423, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1503.7759, -10.713993, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1315.8429, 100.18967, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(1310.4668, 151.57263, 20), "SpawnPointCollection5.d_irredians_113_1");
		AddSpawnPoint("d_irredians_113_1", Spot(976.7984, 219.0875, 20), "SpawnPointCollection5.d_irredians_113_1");

	}
}
