using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLiteLoot.LootItems.Valuables
{
    //         unsure how i should implement gold in inventory (which cant be "used")
    //         - so i added "Misc. valuable items" which can be "sold" to gain gold,
    //         which is stored on character and not in inventory
    public abstract class Valuable : Loot
    {
        public int ValueInGoldCoins { get; protected set; }
        protected Valuable(int valueInGoldCoins)
        {
            ValueInGoldCoins = valueInGoldCoins;
        }
        public override abstract string ApplyEffect(Character character);
    }
}
