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
            if (character.heldWeapon != null)
            {
                character.inventory.Add(character.heldWeapon);

                character.heldWeapon = this;
            }
            character.rangedDamage = Damage;
            return $"{character.name} equipped the {Name} which has {Damage} Ranged Damage!";
        }
    }
}
