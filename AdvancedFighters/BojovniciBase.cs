using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Linq;

namespace AdvancedFighters
{
    abstract class BojovniciBase
    {

        public string Name { get; set; }


        public int Health { get; set; }


        public int Damage { get; set; }


        public BojovniciBase(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        virtual public int AttackEnemy(BojovniciBase heroes)
        {
            return heroes.TakeDamage(); //volá metodu take damage
        }


        virtual public int TakeDamage()
        {
                Health -= Damage;
                Console.WriteLine(" " + Name + " obdržel " + Damage + " bodů poškození!");
                return Damage;
        }

        public void State() 
        {
            string filePath = @"C:\Users\omen\source\repos\AdvancedFighters\ZapisVyhercu.txt";

            if (Health > 0)
            {
                Console.WriteLine("Zbývající životy útočníka " + Name + " jsou: " + Health);
            }
            else
            {
                Console.WriteLine("Útočník " + Name + " prohrál!");

                List<string> lines = new List<string>();
                lines = File.ReadAllLines(filePath).ToList();

                lines.Add("Útočník " + Name + " prohrál!");
                File.WriteAllLines(filePath, lines);

                System.Environment.Exit(0);
            }
        }
    }
}
