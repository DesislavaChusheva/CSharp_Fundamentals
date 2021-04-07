using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._04.MixedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstRow = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse)
                                        .ToList();
            List<int> secondRow = Console.ReadLine()
                                         .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                         .Select(int.Parse)
                                         .ToList();

            int shorterListLenght = Math.Min(firstRow.Count, secondRow.Count);
            List<int> mixedList = new List<int>(shorterListLenght * 2);
            int firstIndex = 0;
            int secondIndex = secondRow.Count - 1;
            int stepIndex = 0;

            if (firstRow.Count > secondRow.Count)
            {
                for (int i = 0; i < secondRow.Count; i++)
                {
                    mixedList.Insert(stepIndex, firstRow[firstIndex]);
                    mixedList.Insert(stepIndex + 1, secondRow[secondIndex]);
                    stepIndex += 2;
                    firstIndex++;
                    secondIndex--;
                }
            }
            else
            {
                for (int i = 0; i < firstRow.Count; i++)
                {
                    mixedList.Insert(stepIndex, firstRow[firstIndex]);
                    mixedList.Insert(stepIndex, secondRow[secondIndex]);
                    stepIndex += 2;
                    firstIndex++;
                    secondIndex--;

                }
            }

            int[] range = new int[2];

            if (firstRow.Count > secondRow.Count)
            {
                range[0] = firstRow[firstRow.Count - 2];
                range[1] = firstRow[firstRow.Count - 1];
            }
            else
            {
                range[0] = secondRow[0];
                range[1] = secondRow[1];
            }

            List<int> finalList = new List<int>();

            for (int i = 0; i < mixedList.Count; i++)
            {
                if (mixedList[i] > Math.Min(range[0], range[1]) && mixedList[i] < Math.Max(range[0], range[1]))
                {
                    finalList.Add(mixedList[i]);
                }
            }

            finalList.Sort();

            Console.WriteLine(string.Join(" ", finalList));
        }
    }
}
