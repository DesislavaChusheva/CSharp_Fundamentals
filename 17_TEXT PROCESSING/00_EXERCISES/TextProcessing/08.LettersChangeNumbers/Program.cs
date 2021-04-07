using System;
using System.Linq;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();

            double finalSum = 0;
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < input.Length; i++)
            {
                char firstLetter = input[i][0];
                char lastLetter = input[i][input[i].Length - 1];
                double number = double.Parse(input[i].Substring(1, input[i].Length - 2));


                if (firstLetter >= 65 && firstLetter <= 90)
                {
                    number /= (alphabet.IndexOf(char.ToUpper(firstLetter)) + 1);
                }
                else
                {
                    number *= (alphabet.IndexOf(char.ToUpper(firstLetter)) + 1);
                }
                if (lastLetter >= 65 && lastLetter <= 90)
                {
                    number -= (alphabet.IndexOf(char.ToUpper(lastLetter)) + 1);
                }
                else
                {
                    number += (alphabet.IndexOf(char.ToUpper(lastLetter)) + 1);
                }
                finalSum += number;
            }
            Console.WriteLine($"{finalSum:f2}");
        }
    }
}
