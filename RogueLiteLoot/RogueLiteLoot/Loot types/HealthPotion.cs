using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLiteLoot
{
    class HealthPotion : Loot
    {
        private int healAmount = 10;

        public HealthPotion(int heal) : base("Health Potion")
        { 
            this.healAmount = heal;
        }

        public override void ApplyEffect(Character character)
        {
            character.healthPoints += healAmount;
            Console.SetCursorPosition(0, 15);
            Console.WriteLine($"{character.name} was healed by {healAmount}!");
        }
    }
}
