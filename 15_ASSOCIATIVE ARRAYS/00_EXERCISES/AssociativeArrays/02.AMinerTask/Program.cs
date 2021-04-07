using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();

            Dictionary<string, int> collection = new Dictionary<string, int>();

            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!collection.ContainsKey(resource))
                {
                    collection.Add(resource, 0);
                }
                collection[resource] += quantity;

                resource = Console.ReadLine();
            }

            foreach (var item in collection)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
