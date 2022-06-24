using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;

namespace UtilitySlots
{
    public static class ItemClassification
    {
        //Does not include fire walker or flower growing boots
        public static HashSet<int> ShoeIds = new HashSet<int>
        {
            54, 128, 405, 863, 898, 907, 1579, 1862, 3200, 3990, 4055, 5000,
        };

        public static HashSet<int> ModShoes = new HashSet<int>();

        public static HashSet<int> JumpIds = new HashSet<int> {
            //Horseshoes
            158, 396,
            //Cloud in bottle
            53, 857, 987, 3201, 1724,
            //in a balloon
            399, 983, 1163, 1863, 3241, 
            //balloons
            159, 1164, 1249, 1250, 1251, 1252, 3225, 3250, 3251, 3252
        };
        public static HashSet<int> ModJumps = new HashSet<int>();

        public static HashSet<int> WingIds = new HashSet<int>
        {
            4978, 5035, 2494, 493, 492, 1162, 761, 785, 822, 748, 821, 1515,
            749, 1165, 1866, 786, 1871, 2280, 1830, 1797, 3883, 823, 2770,
            823, 2609, 948, 3924, 1586, 1585, 1583, 4823, 4750, 4730, 4754,
            3582, 3228, 3928, 3592, 665, 4746, 3588, 1584, 3580, 3468, 3471,
            3470, 3469, 4954
        };

        public static HashSet<int> ModWings = new HashSet<int>();

        public static bool IsShoeAccessory(this Item item) => item.accessory && (ShoeIds.Contains(item.type) || ModShoes.Contains(item.type));

        public static bool IsJumpAccessory(this Item item) => item.accessory && (JumpIds.Contains(item.type) || ModJumps.Contains(item.type));

        public static bool IsWingAccessory(this Item item) => item.accessory && (WingIds.Contains(item.type) || ModWings.Contains(item.type) || item.IsAir); //leaving IsAir for compatibility, maybe

        public static bool AddModShoe(int id) => ModShoes.Add(id);

        public static bool AddModShoes(IEnumerable<int> ids) => ids.Select(AddModShoe).All(added => added);

        public static bool AddModWing(int id) => ModWings.Add(id);

        public static bool AddModWings(IEnumerable<int> ids) => ids.Select(AddModWing).All(added => added);

        public static bool AddModJump(int id) => ModJumps.Add(id);

        public static bool AddModJumps(IEnumerable<int> ids) => ids.Select(AddModJump).All(added => added);
    }
}
