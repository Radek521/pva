using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace AdvancedFighters
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BojovniciBase> heroes = new List<BojovniciBase>();

            Bojovnik bojovnik = new Bojovnik("Alex", 150 , 20, 2);
            Berserker berserker = new Berserker("Mathias", 250, 30);
            Mage mage  =  new Mage ("Mark", 50, 80);
            Lukostrelec lukostrelec = new Lukostrelec("Jessee", 100, 35);

            heroes.Add(bojovnik);
            heroes.Add(berserker);
            heroes.Add(mage);
            heroes.Add(lukostrelec);

            var random = new Random();

            int Bojovnik1 = random.Next(0, 4);
            int Bojovnik2 = random.Next(0, 4);


            if (Bojovnik1 == Bojovnik2)
            {
                Console.WriteLine(" Bojovníci se shodují. Tento souboj by trval nekonečně (fakt dlouho)." +
                    " Stiskněte R pro restart aplikace.");

                var info = Console.ReadKey();
                if (info.Key == ConsoleKey.R)
                {
                    string filePath = @"C:\Users\omen\source\repos\AdvancedFighters\AdvancedFighters.sln";
                    System.Diagnostics.Process.Start(filePath);
                }
            }

            Console.WriteLine(" V tomto zápasu jsou: ");
            Console.WriteLine("  ");
            Console.WriteLine(heroes[Bojovnik1]);
            Console.WriteLine(" VERSUS ");
            Console.WriteLine(heroes[Bojovnik2]);
            Console.WriteLine("  ");
            Console.WriteLine(" FIGHT! ");

            while (true)
            {
                heroes[Bojovnik1].AttackEnemy(heroes[Bojovnik2]);
                heroes[Bojovnik2].State();
                Console.WriteLine("  ");
                heroes[Bojovnik2].AttackEnemy(heroes[Bojovnik1]);
                heroes[Bojovnik1].State();
                Console.WriteLine("  ");
            }
          
        }
    }
}
