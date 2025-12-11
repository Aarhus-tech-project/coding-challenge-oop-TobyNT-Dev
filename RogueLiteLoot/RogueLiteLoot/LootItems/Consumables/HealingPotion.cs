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
            if (NumberOfUses < 1) character.inventory.Remove(this);
            return $"Health Potion was used by {character.name}, and healed {Potency} HP!";
        }
    }
}
