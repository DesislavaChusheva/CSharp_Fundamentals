using System;
using System.Collections.Generic;

namespace _01.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<char, int> occurences = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    if (!occurences.ContainsKey(input[i]))
                    {
                        occurences.Add(input[i], 0);
                    }
                    occurences[input[i]]++;
                }
            }

            foreach (var character in occurences)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }
        }
    }
}
