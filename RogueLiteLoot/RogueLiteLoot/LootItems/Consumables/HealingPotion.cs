using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLiteLoot.LootItems.Consumables
{
    public class HealingPotion : Potion
    {
        public HealingPotion(int Potency) :base(Potency) 
        {
            Name = "Healing Potion";
            Action = "Drink";
        }

        public override string ApplyEffect(Character character)
        {
            character.healthPoints += Potency;
            NumberOfUses--;

            return $"Health Potion was used by {character.name}, and healed {Potency} HP!";
        }
    }
}
