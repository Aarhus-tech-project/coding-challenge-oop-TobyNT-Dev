using System;
using System.Collections.Generic;
using System.Text;

namespace RogueLiteLoot
{
    abstract class Loot
    {
        public string Name { get; }

        public Loot(string name)
        {
            Name = name;
        }

        public abstract void ApplyEffect(Character character);
    }
}
