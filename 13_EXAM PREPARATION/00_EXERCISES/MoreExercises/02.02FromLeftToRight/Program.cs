using System;
using System.Linq;

namespace _02._02FromLeftToRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                long[] numbers = Console.ReadLine()
                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                       .Select(long.Parse)
                                       .ToArray();
                if (numbers[0] > numbers [1])
                {
                    SumOfDigits(numbers[0]);  
                }
                else
                {
                    SumOfDigits(numbers[1]);
                }
            }
            static void SumOfDigits(long number)
            {
                long sum = 0;

                while (number != 0)
                {
                    sum += number % 10;
                    number /= 10;
                }

                Console.WriteLine(Math.Abs(sum));
            }
        }
    }
}
