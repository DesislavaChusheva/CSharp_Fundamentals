using System;

namespace _01.SmallestofThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallestNumber(firstNumber, secondNumber, thirdNumber));
        }

        private static int SmallestNumber(int firstNumber, int secondNumber, int thirdNumber)
        {
            int a = Math.Min(firstNumber, secondNumber);
            int b = Math.Min(a, thirdNumber);

            return b;
        }
    }
}
