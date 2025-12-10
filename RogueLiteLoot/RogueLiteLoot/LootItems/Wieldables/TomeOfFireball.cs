using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLiteLoot.LootItems.Wieldables
{
    public class TomeOfFireball : MagicWeapon
    {
        public TomeOfFireball(int Damage) : base(Damage)
        {
            Name = "Tome of Fireball";
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

            character.magicDamage = Damage;
            character.rangedDamage = 0;
            character.meleeDamage = 0;
            return $"{character.name} equipped the {Name} which has {Damage} Magic Damage!";
        }
    }
}
