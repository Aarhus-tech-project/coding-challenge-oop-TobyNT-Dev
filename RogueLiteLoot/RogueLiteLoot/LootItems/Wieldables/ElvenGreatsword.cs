using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLiteLoot.LootItems.Wieldables
{
    public class ElvenGreatsword : MeleeWeapon
    {
        public ElvenGreatsword(int Damage) : base(Damage)
        {
            Name = "Elven Greatsword";
            Action = "Equip";
        }

        public override string ApplyEffect(Character character)
        {
            // if player has something equipped, then move that back to inventory, and then equip
            if (character.heldWeapon != null)
            {
                if (character.heldWeapon is Fists)
                {
                    // do nothing & dont add fists to inventory
                }
                else
                {
                    character.inventory.Add(character.heldWeapon);
                }
            }
            character.heldWeapon = this;
            character.inventory.Remove(this);
            character.meleeDamage = Damage;
            character.magicDamage = 0;
            character.rangedDamage = 0;
            return $"{character.name} equipped the {Name} which has {Damage} Melee Damage!";
        }
    }
}
