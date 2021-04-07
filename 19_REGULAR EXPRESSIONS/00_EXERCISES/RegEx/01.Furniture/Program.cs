using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>([A-z]+)<<(\d+.?\d+)!(\d+)";
            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();
            double totalPrice = 0.0;
            List<string> boughtFurniture = new List<string>();
            boughtFurniture.Add("Bought furniture:");

            while (input != "Purchase")
            {
                Match match = regex.Match(input);

                if (match.Success)
                {
                    string name = match.Groups[1].Value;
                    double price = double.Parse(match.Groups[2].Value);
                    int quantity = int.Parse(match.Groups[3].Value);

                    boughtFurniture.Add(name);

                    totalPrice += price * quantity;

                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join("\n",boughtFurniture));
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
