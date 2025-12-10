using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLiteLoot.LootItems.Wieldables
{
    public abstract class RangedWeapon : Wieldable
    {
        public int Damage { get; protected set; }
        protected RangedWeapon(int damage)
        {
            Damage = damage;
        }

        public override abstract string ApplyEffect(Character character);
    }
}
