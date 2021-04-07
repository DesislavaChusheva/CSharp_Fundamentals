using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine().TrimStart('0');
            int secondNumber = int.Parse(Console.ReadLine());
            int balance = 0;

            if (secondNumber == 0 || firstNumber == "")
            {
                Console.WriteLine(0);
                return;
            }
            StringBuilder sb = new StringBuilder();

            foreach (char ch in firstNumber.Reverse())
            {
                int digit = int.Parse(ch.ToString());
                int result = digit * secondNumber + balance;

                int resultDigit = result % 10;
                balance = result / 10;

                sb.Insert(0, resultDigit);
            }
            if (balance > 0)
            {
                sb.Insert(0, balance);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
