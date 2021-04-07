using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{(Factorial(firstNumber) / Factorial(secondNumber)):f2}");
        }

        private static double Factorial(int number)
        {
            double factorial = 1;
            for (int i = number; i >= 1 ; i--)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
