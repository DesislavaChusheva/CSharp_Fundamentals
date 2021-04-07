using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                                        .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToList();


            for (int i = 0; i < input.Count; i++)
            {
                if (    input[i].Length >= 3 
                    &&  input[i].Length <= 16 
                    && (input[i].All(c => char.IsLetterOrDigit(c)) 
                    ||  input[i].Contains("_") 
                    ||  input[i].Contains("-")))
                {
                    Console.WriteLine(input[i]);
                }
            }
        }
    }
}
