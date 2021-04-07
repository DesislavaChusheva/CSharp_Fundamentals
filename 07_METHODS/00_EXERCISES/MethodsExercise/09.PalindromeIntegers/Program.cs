using System;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                Console.WriteLine(IsPalindrome(input).ToString().ToLower());
                input = Console.ReadLine();
            }
        }

        private static bool IsPalindrome(string input)
        {
            char[] array = input.ToCharArray();
            Array.Reverse(array);
            string reversedInput = new string(array);
            return (input == reversedInput);
        }
    }
}
