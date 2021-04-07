using System;
using System.Linq;

namespace _03.Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            string[] firstArray = new string[numberOfLines];
            string[] secondArray = new string[numberOfLines];

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] line = Console.ReadLine().Split(" ");
                if (i % 2 == 0)
                {
                    firstArray[i] = line[0];
                    secondArray[i] = line[1];
                }
                else
                {
                    firstArray[i] = line[1];
                    secondArray[i] = line[0];
                }
            }

            Console.WriteLine(string.Join(" ", firstArray));
            Console.WriteLine(string.Join(" ", secondArray));
        }
    }
}
