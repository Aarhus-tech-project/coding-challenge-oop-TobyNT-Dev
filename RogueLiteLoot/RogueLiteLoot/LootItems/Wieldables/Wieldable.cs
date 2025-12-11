using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLiteLoot.LootItems.Wieldables
{
    public abstract class Wieldable : Loot
    {
        public override abstract string ApplyEffect(Character character);
    }
}
