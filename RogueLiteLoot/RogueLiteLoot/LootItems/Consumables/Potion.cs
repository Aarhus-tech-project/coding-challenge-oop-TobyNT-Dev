using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLiteLoot.LootItems.Consumables
{
    public abstract class Potion : Consumable
    {
        public int Potency { get; protected set; }

        protected Potion(int potency)
        {
            Potency = potency;
        }

        public override abstract string ApplyEffect(Character character);
    }
}
