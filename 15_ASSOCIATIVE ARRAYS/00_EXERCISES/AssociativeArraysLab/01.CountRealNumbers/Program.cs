using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                                     .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToList();

            SortedDictionary<int, int> numbers = new SortedDictionary<int, int>();

            for (int i = 0; i < input.Count; i++)
            {
                if (numbers.ContainsKey(input[i]))
                {
                    numbers[input[i]]++;
                }
                else
                {
                    numbers.Add(input[i], 1);
                }
            }
            foreach (var number in numbers)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
