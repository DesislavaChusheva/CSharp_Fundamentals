using System;
using System.Collections.Generic;
using System.Linq;

namespace _2020._04._04_03.HeroesofCodeandLogicVII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Hero> heros = new Dictionary<string, Hero>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int hp = int.Parse(input[1]);
                int mp = int.Parse(input[2]);
                if (hp > 100)
                {
                    hp = 100;
                }
                if (mp > 200)
                {
                    mp = 200;
                }
                Hero hero = new Hero(hp, mp);
                heros.Add(name, hero);
            }
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArg = command.Split(" - ");
                string action = cmdArg[0];
                string heroName = cmdArg[1];
                switch (action)
                {
                    case "CastSpell":
                        int mpNeeded = int.Parse(cmdArg[2]);
                        string spellName = cmdArg[3];
                        if (mpNeeded > heros[heroName].ManaPoints)
                        {
                            Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                        }
                        else
                        {
                            heros[heroName].ManaPoints -= mpNeeded;
                            Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heros[heroName].ManaPoints} MP!");
                        }
                        break;

                    case "TakeDamage":
                        int damage = int.Parse(cmdArg[2]);
                        string attacker = cmdArg[3];
                        if (damage < heros[heroName].HitPoints)
                        {
                            heros[heroName].HitPoints -= damage;
                            Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heros[heroName].HitPoints} HP left!");
                        }
                        else
                        {
                            heros.Remove(heroName);
                            Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        }
                        break;

                    case "Recharge":
                        int amountMP = int.Parse(cmdArg[2]);
                        int oldMP = heros[heroName].ManaPoints;
                        if (heros[heroName].ManaPoints + amountMP > 200)
                        {
                            heros[heroName].ManaPoints = 200;
                        }
                        else
                        {
                            heros[heroName].ManaPoints += amountMP;
                        }
                        Console.WriteLine($"{heroName} recharged for {heros[heroName].ManaPoints - oldMP} MP!");
                        break;

                    case "Heal":
                        int amountHP = int.Parse(cmdArg[2]);
                        int oldHP = heros[heroName].HitPoints;
                        if (heros[heroName].HitPoints + amountHP > 100)
                        {
                            heros[heroName].HitPoints = 100;
                        }
                        else
                        {
                            heros[heroName].HitPoints += amountHP;
                        }
                        Console.WriteLine($"{heroName} healed for {heros[heroName].HitPoints - oldHP} HP!");
                        break;

                    default:
                        break;
                }

                command = Console.ReadLine();
            }
            foreach (var hero in heros.OrderByDescending(h => h.Value.HitPoints).ThenBy(h => h.Key))
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"HP: {hero.Value.HitPoints}");
                Console.WriteLine($"MP: {hero.Value.ManaPoints}");
            }
        }

        class Hero
        {
            public Hero(int hitPoints, int manaPoints)
            {
                HitPoints = hitPoints;
                ManaPoints = manaPoints;
            }

            public int HitPoints { get; set; }
            public int ManaPoints { get; set; }

        }
    }
}
