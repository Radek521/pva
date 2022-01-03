using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedFighters
{
    class Berserker : BojovniciBase
    {
        public Berserker(string name, int health, int damage) : base(name, health, damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public override int AttackEnemy(BojovniciBase heroes)
        {
            var rand = new Random();
            var chance = rand.Next(10, 13);

            if (chance == 11)
            {
                Console.WriteLine("Berserker zaútočil dvakrát!");     
                base.TakeDamage();
            }

            return base.TakeDamage();
        }
    }
}
