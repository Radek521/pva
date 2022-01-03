using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedFighters
{
    class Lukostrelec : BojovniciBase
    {
        public Lukostrelec(string name, int health, int damage) : base(name, health, damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        override public int TakeDamage()
        {
            var rand = new Random();
            var chance = rand.Next(10, 13);

            if(chance == 11)
            {
                Console.WriteLine("Lukostřelec " + Name + " se vyhnul útoku!");
                return 0;
            }
            else
            {
                return base.TakeDamage();
            } 
        }
    }
}
