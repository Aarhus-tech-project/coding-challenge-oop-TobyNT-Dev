using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLiteLoot.LootItems.Consumables
{
    public abstract class Food : Consumable
    {
        public int Quality { get; protected set; }

        protected Food(int quality)
        {
            Quality = quality;
        }

        public override abstract string ApplyEffect(Character character);
    }
}
