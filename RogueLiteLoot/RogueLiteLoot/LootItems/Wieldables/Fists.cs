using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLiteLoot.LootItems.Wieldables
{
    public class Fists : MeleeWeapon
    {
        public Fists(int Damage) : base(Damage)
        {
            Name = "Fists";
            Action = "Equip";
        }

        public override string ApplyEffect(Character character)
        {
            // if player has something equipped, then move that back to inventory, and then equip
            if (character.heldWeapon != null)
            {
                character.inventory.Add(character.heldWeapon);
                
            }
            character.heldWeapon = this;
            character.meleeDamage = Damage;
            character.magicDamage = 0;
            character.rangedDamage = 0;
            return $"{character.name} equipped their {Name} which has {Damage} Melee Damage!";
        }
    }
}
