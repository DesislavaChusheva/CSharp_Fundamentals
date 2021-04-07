using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine()
                                     .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                     .Select(double.Parse)
                                     .ToList();

            double averageNumber = (input.Sum() / input.Count)*1.0;
            List<double> graterThanAv = new List<double>();

            foreach (double item in input)
            {
                if (item > averageNumber)
                {
                    graterThanAv.Add(item);
                }
            }

            if (graterThanAv.Count == 0)
            {
                Console.WriteLine("No");
                Environment.Exit(0);
            }
            graterThanAv.Sort();
            graterThanAv.Reverse();

            if (graterThanAv.Count > 5)
            {
                graterThanAv = graterThanAv.GetRange(0, 5);
            }

            Console.WriteLine(string.Join(" ",graterThanAv));
        }
    }
}
