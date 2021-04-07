using System;

namespace _05.AddandSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(Substract(Sum(firstNumber, secondNumber), thirdNumber));
        }

        private static int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        private static int Substract(int sum, int thirdNumber)
        {
            return sum - thirdNumber;
        }
    }
}
