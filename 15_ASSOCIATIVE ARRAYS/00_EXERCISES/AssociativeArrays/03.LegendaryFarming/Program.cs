using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            keyMaterials.Add("shards", 0);
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("motes", 0);
            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();

            while (keepGoing)
            {
                List<string> inputLine = Console.ReadLine()
                                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                                .ToList();
                for (int i = 0; i < inputLine.Count; i += 2)
                {
                    int quantity = int.Parse(inputLine[i]);
                    string material = inputLine[i + 1].ToLower();

                    if (material == "shards")
                    {
                        keyMaterials["shards"] += quantity;
                        if (keyMaterials["shards"] >= 250)
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                            keyMaterials["shards"] -= 250;
                            keepGoing = false;
                            break;
                        }
                    }
                    else if (material == "fragments")
                    {
                        keyMaterials["fragments"] += quantity;
                        if (keyMaterials["fragments"] >= 250)
                        {
                            Console.WriteLine("Valanyr obtained!");
                            keyMaterials["fragments"] -= 250;
                            keepGoing = false;
                            break;
                        }
                    }
                    else if (material == "motes")
                    {
                        keyMaterials["motes"] += quantity;
                        if (keyMaterials["motes"] >= 250)
                        {
                            Console.WriteLine("Dragonwrath obtained!");
                            keyMaterials["motes"] -= 250;
                            keepGoing = false;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials.Add(material, 0);
                        }
                        junkMaterials[material] += quantity;
                    }

                }
            }
            foreach (var item in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junkMaterials.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
