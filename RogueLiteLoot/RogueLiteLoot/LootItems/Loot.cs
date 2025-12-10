using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLiteLoot.LootItems
{
    public abstract class Loot
    {
        public string Name { get; set; }
        public string Action { get; set; }

        public abstract string ApplyEffect(Character character);
    }
}
