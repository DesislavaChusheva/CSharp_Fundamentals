using System;
using System.Linq;

namespace _03._04.FoldTheSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();

            int[] firstRow = new int[array.Length / 2];
            int[] secondRow = new int[array.Length / 2];
            int range1 = array.Length / 4 - 1;
            int range2 = array.Length - 1;
            int range3 = array.Length / 4;

            for (int i = 0; i < array.Length/4; i++)
            {
                firstRow[i] = array[range1];
                firstRow[range3] = array[range2];

                range1 -= 1;
                range2 -= 1;
                range3 += 1;
            }

            int secondRowIndex = 0;
            for (int i = array.Length / 4; i <= array.Length - array.Length/4 - 1; i++)
            {
                secondRow[secondRowIndex] = array[i];
                secondRowIndex += 1;
            }

            int[] sumArray = new int[array.Length / 2];
            for (int i = 0; i < sumArray.Length; i++)
            {
                sumArray[i] = firstRow[i] + secondRow[i];
            }

            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
