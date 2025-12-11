using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLiteLoot.LootItems.Wearables
{
    public abstract class Wearable : Loot
    {
        
        public override abstract string ApplyEffect(Character character);
    }
}
