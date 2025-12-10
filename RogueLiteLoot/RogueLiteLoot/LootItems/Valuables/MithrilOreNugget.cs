using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLiteLoot.LootItems.Valuables
{
    public class MithrilOreNugget : Valuable
    {
        public MithrilOreNugget(int ValueInGoldCoins) : base(ValueInGoldCoins)
        {
            Name = "Mithril Ore Nugget";
            Action = "Sell";
        }

        public override string ApplyEffect(Character character)
        {
            character.goldCoins += ValueInGoldCoins;

            character.inventory.Remove(this);
            return $"{character.name} sold his {Name}, and gained {ValueInGoldCoins} Gold Coins!";
        }
    }
}
