using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();

            while (input != "buy")
            {
                string[] currentProductInformation = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                List<double> priceAndQuantity = new List<double>(2);
                priceAndQuantity.Add(double.Parse(currentProductInformation[1]));
                priceAndQuantity.Add(double.Parse(currentProductInformation[2]));
                string product = currentProductInformation[0];

                if (!products.ContainsKey(product))
                {
                    products.Add(product, priceAndQuantity);
                }
                else
                {
                    products[product][0] = priceAndQuantity[0];
                    products[product][1] += priceAndQuantity[1];
                }

                input = Console.ReadLine();
            }

            foreach (var product in products)
            {
                double cost = product.Value[0] * product.Value[1];
                Console.WriteLine($"{product.Key} -> {cost:f2}");
            }
        }
    }
}
