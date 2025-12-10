using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLiteLoot.LootItems.Wieldables
{
    public class ElvenGreatsword : MagicWeapon
    {
        public ElvenGreatsword(int Damage) : base(Damage)
        {
            Name = "Elven Greatsword";
            Action = "Equip";
        }

        public override string ApplyEffect(Character character)
        {
            if (character.heldWeapon != null)
            {
                character.inventory.Add(character.heldWeapon);

                character.heldWeapon = this;
            }

            character.meleeDamage = Damage;

            return $"{character.name} equipped the {Name} which has {Damage} Melee Damage!";
        }
    }
}
