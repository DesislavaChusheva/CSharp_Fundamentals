using System;

namespace _01._01.SortNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = new int[3];

            for (int i = 0; i < 3; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(input);
            Array.Reverse(input);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
    }
}
