using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLiteLoot.LootItems.Wearables
{
    public class PaddedRingmail : Wearable, IArmor, ICosmeticClothing
    {
        public int ArmorRating { get; set; }
        public int FashionRating { get; set; }
        public PaddedRingmail(int armorRating, int fashionRating)
        {
            ArmorRating = armorRating;
            FashionRating = fashionRating;

            Name = "Padded Ringmail";
            Action = "Equip";
        }
        public override string ApplyEffect(Character character)
        {
            // is character already wearing armor ?
            if (character.armorWorn != null)
            {
                character.inventory.Add(character.armorWorn);
            }
            //no armor equipped
            character.armor = ArmorRating;
            character.armorWorn = this;
            
            // is character already wearing cosmetic ?
            if (character.cosmeticApparel != null)
            {
                character.inventory.Add(character.cosmeticApparel);
            }
            //no cosmetic equipped
            character.cosmeticApparel = this;
            character.fashionRating = FashionRating;
            character.inventory.Remove(this);
            return $"{character.name} equipped {Name} with {ArmorRating} Armor and {FashionRating} Fashion Rating!";
        }
    }
}
