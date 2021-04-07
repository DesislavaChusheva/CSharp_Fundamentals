using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfArrays = Console.ReadLine()
                                               .Split("|", StringSplitOptions.RemoveEmptyEntries)
                                               .ToList();
            List<string> newListOfArrays = new List<string>();

            for (int i = listOfArrays.Count - 1; i >= 0; i--)
            {
                string[] array = listOfArrays[i]
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .ToArray();
                for (int j = 0; j < array.Length; j++)
                {
                    newListOfArrays.Add(array[j]);
                }
            }
            Console.WriteLine(string.Join(" ", newListOfArrays));
        }
    }
}
