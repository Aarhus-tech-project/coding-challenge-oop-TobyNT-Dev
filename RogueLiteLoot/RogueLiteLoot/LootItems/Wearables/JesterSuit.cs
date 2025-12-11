using RogueLiteLoot.LootItems.Consumables;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace RogueLiteLoot.LootItems.Wearables
{
    public class JesterSuit : CosmeticClothing
    {
        public JesterSuit(int FashionRating) : base(FashionRating)
        {
            Name = "Jester's Suit";
            Action = "Equip";
        }
        public override string ApplyEffect(Character character)
        {
            if (character.cosmeticApparel != null)
            {
                if (character.cosmeticApparel == character.armorWorn)
                {
                    character.inventory.Add(character.cosmeticApparel);

                    character.armor = 0;
                    character.armorWorn = null;
                }
                else
                {
                    //send old cosmetic to inventory
                    character.inventory.Add(character.cosmeticApparel);
                }
            }
            character.fashionRating = FashionRating;
            character.cosmeticApparel = this;
            character.inventory.Remove(this);
            return $"{character.name}, Equipped {Name}, which had {FashionRating} Fashion Rating!";
        }
    }
}
