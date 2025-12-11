using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace RogueLiteLoot.LootItems.Consumables
{
    public abstract class Consumable : Loot
    {
        public int NumberOfUses { get; protected set; } = 1;

        public override abstract string ApplyEffect(Character character);
    }
}
