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
            if (character.heldWeapon != null)
            {
                character.inventory.Add(character.heldWeapon);

                character.heldWeapon = this;
            }
            character.magicDamage = Damage;

            return $"{character.name} equipped the {Name} which has {Damage} Magic Damage!";
        }
    }
}
