using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            TopNumber(number);
        }

        private static void TopNumber(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                bool odd = false;
                int digit = i;

                while (digit % 10 > 0)
                {
                    sum += digit % 10;

                    if (digit/2 == 0)
                    {
                        odd = true;
                    }

                    digit /= 10;
                }

                if (odd && (sum % 8 == 0))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
