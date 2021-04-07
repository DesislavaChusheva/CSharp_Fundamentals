using System;
using System.Linq;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();

            Console.WriteLine(CharMulti(input[0], input[1]));
        }
        public static int CharMulti (string firstString, string secondString)
        {
            string longer = firstString;
            string shorter = secondString;
            if (shorter.Length > longer.Length)
            {
                longer = secondString;
                shorter = firstString;
            }

            int sum = 0;
            for (int i = 0; i < shorter.Length; i++)
            {
                sum += shorter[i] * longer[i];
            }
            for (int i = shorter.Length; i < longer.Length; i++)
            {
                sum += longer[i];
            }
            return sum;
        }
    }
}
