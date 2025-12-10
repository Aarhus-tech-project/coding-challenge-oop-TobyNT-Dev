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
                    character.inventory.Add(character.cosmeticApparel);

                    character.armor = ArmorRating;
                    character.armorWorn = this;
                    character.cosmeticApparel = null;
                }
                else
                {
                    //replace allready worn cosmetic with new, and send old to inventory
                    character.inventory.Add(character.armorWorn);

                    character.armor = ArmorRating;
                    character.armorWorn = this;

                }
            }

            return $"{character.name}, Equipped {Name}, which had {ArmorRating} Armor!";
        }
    }
}
