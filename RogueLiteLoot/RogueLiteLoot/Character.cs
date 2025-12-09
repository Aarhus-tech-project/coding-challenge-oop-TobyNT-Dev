using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLiteLoot
{
    internal class Character
    {
        public string name = "Gandalf";

        public List<Loot> inventory;

        public int strength = 1;
        public int healthPoints = 100;
        
        public void Use(Loot loot)
        {
            loot.ApplyEffect(this);
        }
    }
}