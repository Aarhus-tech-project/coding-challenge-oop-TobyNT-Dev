using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLiteLoot
{
    class StrengthPotion : Loot
    {
        private int strengthAmount = 5;

        public StrengthPotion(int heal) : base("Health Potion")
        { 
            this.strengthAmount = heal;
        }

        public override void ApplyEffect(Character character)
        {
            character.healthPoints += strengthAmount;
            Console.SetCursorPosition(0, 15);
            Console.WriteLine($"{character.name} increased their strength by {strengthAmount}!");
        }
    }
}
