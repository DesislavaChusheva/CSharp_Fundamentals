using System;
using System.Collections.Generic;
using System.Linq;

namespace _2020._04._04_03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, City> cities = new Dictionary<string, City>();
            while (input != "Sail")
            {
                string[] cmdArg = input.Split("||");
                string city = cmdArg[0].ToString();
                int population = int.Parse(cmdArg[1]);
                int gold = int.Parse(cmdArg[2]);
                City currCity = new City(population, gold);

                if (cities.ContainsKey(cmdArg[0].ToString()))
                {
                    cities[city].Population += population;
                    cities[city].Gold += gold;
                }
                else
                {
                    cities.Add(city, currCity);
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "End")
            {
                string[] cmdArg = input.Split("=>");
                string command = cmdArg[0];
                string city = cmdArg[1];

                if (command == "Plunder")
                {
                    int people = int.Parse(cmdArg[2]);
                    int gold = int.Parse(cmdArg[3]);
                    Console.WriteLine($"{city} plundered! {gold} gold stolen, {people} citizens killed.");
                    cities[city].Population -= people;
                    cities[city].Gold -= gold;
                    if (cities[city].Population <= 0 || cities[city].Gold <= 0)
                    {
                        Console.WriteLine($"{city} has been wiped off the map!");
                        cities.Remove(city);
                    }

                }
                else
                {
                    int gold = int.Parse(cmdArg[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        cities[city].Gold += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {city} now has {cities[city].Gold} gold.");
                    }
                }

                input = Console.ReadLine();
            }
            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (var city in cities.OrderByDescending(x => x.Value.Gold).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value.Population} citizens, Gold: {city.Value.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
        public class City
        {
            public City(int population, int gold)
            {
                Population = population;
                Gold = gold;
            }
            public int Population { get; set; }
            public int Gold { get; set; }
        }
    }
}
