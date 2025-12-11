using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLiteLoot.LootItems.Wieldables
{
    public abstract class MagicWeapon : Wieldable
    {
        public int Damage { get; protected set; }
        protected MagicWeapon(int damage)
        {
            Damage = damage;
        }

        public override abstract string ApplyEffect(Character character);
    }
}
