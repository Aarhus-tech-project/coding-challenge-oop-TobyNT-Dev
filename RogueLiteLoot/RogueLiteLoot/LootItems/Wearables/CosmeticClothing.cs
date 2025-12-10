using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLiteLoot.LootItems.Wearables
{
    public abstract class CosmeticClothing : Wearable, ICosmeticClothing
    {
        public int FashionRating { get; set; }
        protected CosmeticClothing(int fashionRating)
        {
            FashionRating = fashionRating;
        }

        public override abstract string ApplyEffect(Character character);
    }
}
