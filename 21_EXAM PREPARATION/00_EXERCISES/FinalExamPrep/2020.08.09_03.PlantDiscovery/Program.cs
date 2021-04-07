using System;
using System.Collections.Generic;
using System.Linq;

namespace _2020._08._09_03.PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Plant> plants = new Dictionary<string, Plant>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string plant = input[0].Trim();
                int rarity = int.Parse(input[1]);

                if (plants.ContainsKey(plant))
                {
                    plants[plant].Rarity = rarity;
                }
                else
                {
                    Plant currPlant = new Plant(rarity, new List<int>());
                    plants.Add(plant, currPlant);
                }
            }

            string command = Console.ReadLine();

            while (command != "Exhibition")
            {
                string[] cmdArg = command.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArg[0];
                string[] data = cmdArg[1].Split('-', StringSplitOptions.RemoveEmptyEntries);
                string plant = data[0].Trim();

                switch (action)
                {
                    case "Rate":
                        if (IsDigit(data[1]) && plants.ContainsKey(plant))
                        {
                            int rating = int.Parse(data[1]);
                            plants[plant].Rating.Add(rating);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;

                    case "Update":
                        if (IsDigit(data[1]) && plants.ContainsKey(plant))
                        {
                            int newRarity = int.Parse(data[1]);
                            plants[plant].Rarity = newRarity;
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;

                    case "Reset":
                        if (plants.ContainsKey(plant))
                        {
                            plants[plant].Rating.Clear();
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in plants.OrderByDescending(p => p.Value.Rarity).ThenByDescending(p => p.Value.Rating.Sum() != 0 ? p.Value.Rating.Sum() * 1.0 / p.Value.Rating.Count : 0))
            {
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value.Rarity}; Rating: {(plant.Value.Rating.Sum() != 0 ? plant.Value.Rating.Sum() * 1.0 / plant.Value.Rating.Count : 0):f2}");
            }
        }
        public static bool IsDigit(string input)
        {
            input = input.Trim();
            bool flag = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsDigit(input[i]))
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
        class Plant
        {
            public Plant(int rarity, List<int> rating)
            {
                Rarity = rarity;
                Rating = rating;
            }
            public int Rarity { get; set; }
            public List<int> Rating { get; set; }
        }
    }
}
