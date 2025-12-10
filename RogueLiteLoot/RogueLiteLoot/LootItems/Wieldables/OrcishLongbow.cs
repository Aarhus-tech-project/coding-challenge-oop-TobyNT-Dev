using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLiteLoot.LootItems.Wieldables
{
    public class OrcishLongbow : MagicWeapon
    {
        public OrcishLongbow(int Damage) : base(Damage)
        {
            Name = "Orcish Longbow";
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
            character.inventory.Remove(this);
            character.rangedDamage = Damage;
            character.meleeDamage = 0;
            character.magicDamage = 0;
            return $"{character.name} equipped the {Name} which has {Damage} Ranged Damage!";
        }
    }
}
