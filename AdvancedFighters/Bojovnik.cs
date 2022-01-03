using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedFighters
{
    class Bojovnik : BojovniciBase
    {
        public int BlockChance { get; set; }
        private readonly Random random;

        public Bojovnik(string name, int health, int damage, int blockChance) : base(name, health, damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
            BlockChance = blockChance;
            random = new Random();
        }

        override public int TakeDamage()
        {
            var chance = random.Next(10, 13);

            if (chance == 11)
            {
                Console.WriteLine("Bojovník " + Name + " se vyhnul útoku!");
                return 0;
            }
            else
            {
              return base.TakeDamage();
            }

        }
    }
}
