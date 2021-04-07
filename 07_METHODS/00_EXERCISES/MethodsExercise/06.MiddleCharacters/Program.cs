using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input.Length % 2 == 0)
            {
                Console.WriteLine(EvenMiddleChar(input));
            }
            else
            {
                Console.WriteLine(OddMiddleChar(input));
            }
        }

        private static string OddMiddleChar(string input)
        {
            return input.Substring((input.Length - 1)/2, 1);
        }

        private static string EvenMiddleChar(string input)
        {
            return input.Substring((input.Length - 1)/2, 2);
        }
    }
}
