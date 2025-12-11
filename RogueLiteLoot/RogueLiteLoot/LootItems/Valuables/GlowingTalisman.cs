using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLiteLoot.LootItems.Valuables
{
    public class GlowingTalisman : Valuable
    {
        public GlowingTalisman(int ValueInGoldCoins) : base(ValueInGoldCoins)
        {
            Name = "Glowing Talisman";
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
