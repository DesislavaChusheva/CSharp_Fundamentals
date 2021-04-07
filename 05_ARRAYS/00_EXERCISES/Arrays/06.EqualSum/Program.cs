using System;
using System.Linq;

namespace _06.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                                 .Split(" ")
                                 .Select(int.Parse)
                                 .ToArray();
            bool noSuchSum = true;

            for (int i = 0; i < array.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j = i-1; j >= 0; j--)
                {
                    leftSum += array[j];
                }
                for (int j = i+1; j < array.Length; j++)
                {
                    rightSum += array[j];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    noSuchSum = false;
                    break;
                }
            }
            if (noSuchSum)
            {
                Console.WriteLine("no");
            }
        }
    }
}
