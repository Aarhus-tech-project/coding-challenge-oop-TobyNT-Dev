using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLiteLoot.LootItems.Consumables
{
    public class Steak : Food
    {
        public Steak(int Quality) : base(Quality)
        {
            Name = "Steak";
            Action = "Eat";
        }

        public override string ApplyEffect(Character character)
        {
            character.strength += Quality;
            NumberOfUses--;
            if (NumberOfUses < 1) character.inventory.Remove(this);
            return $"Steak was eaten by {character.name}, and gave {Quality} strength!";
        }
    }
}