using System;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                                 .Split(" ")
                                 .Select(int.Parse)
                                 .ToArray();
            bool isBigger = true;
            for (int i = 0; i < array.Length; i++)
            {
                isBigger = true;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] <= array[j])
                    {
                        isBigger = false;
                        break;
                    }
                }

                if (isBigger)
                {
                    Console.Write(array[i] + " ");
                }

            }
        }
    }
}
