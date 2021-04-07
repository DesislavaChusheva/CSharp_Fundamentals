using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberForUse = number;
            string numberToString = Convert.ToString(number);
            int factorialSum = 0;

            for (int i = numberToString.Length - 1; i >= 0; i--)
            {
                int certainNumber = numberForUse % 10;
                numberForUse /= 10;
                int factorial = 1;
                for (int j = certainNumber; j >= 1; j--)
                {
                    factorial *= j;
                }
                factorialSum += factorial;
            }

            if (factorialSum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
