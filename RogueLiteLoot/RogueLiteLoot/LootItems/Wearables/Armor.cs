using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLiteLoot.LootItems.Wearables
{
    public abstract class Armor : Wearable, IArmor
    {
        public int ArmorRating { get; set; }
        public Armor(int armorRating)
        {
            ArmorRating = armorRating;
        }
        public override abstract string ApplyEffect(Character character);
    }
}
