using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedFighters
{
    class Mage : BojovniciBase
    {
        public Mage(string name, int health, int damage) : base(name, health, damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

    }
}
