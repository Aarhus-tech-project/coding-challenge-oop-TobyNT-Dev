using RogueLiteLoot.LootItems.Consumables;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace RogueLiteLoot.LootItems.Wearables
{
    public class DwarvenSteelArmor : Armor
    {
        public DwarvenSteelArmor(int ArmorRating) : base(ArmorRating)
        {
            Name = "Dwarven Steel Armor";
            Action = "Equip";
        }

        public override string ApplyEffect(Character character)
        {
            if (character.armorWorn != null)
            {
                if (character.armorWorn == character.cosmeticApparel)
                {
                    character.inventory.Add(character.armorWorn);

                    character.fashionRating = 0;
                    character.cosmeticApparel = null;
                }
                else
                {
                    character.inventory.Add(character.armorWorn);
                }
            }
            character.armor = ArmorRating;
            character.armorWorn = this;
            character.inventory.Remove(this);
            return $"{character.name}, Equipped {Name}, which had {ArmorRating} Armor!";
        }
    }
}
