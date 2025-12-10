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

                    character.cosmeticApparel = this;
                    character.cosmeticApparel = null;
                }
                else
                {
                    //replace allready worn cosmetic with new, and send old to inventory
                    character.inventory.Add(character.cosmeticApparel);

                    character.cosmeticApparel = this;

                }
            }

            return $"{character.name}, Equipped {Name}, which had {FashionRating} Fashion Rating!";
        }
    }
}
