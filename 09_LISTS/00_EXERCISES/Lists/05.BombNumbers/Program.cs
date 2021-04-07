using System;
using System.Collections.Generic;
using System.Linq;


namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> rowOfNumbers = Console.ReadLine()
                                            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .ToList();
            int[] bomb = Console.ReadLine()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToArray();

            for (int i = 0; i < rowOfNumbers.Count; i++)
            {
                if (rowOfNumbers[i] == bomb[0])
                {
                    int startIndex = i - bomb[1];
                    int endIndex = i + bomb[1];

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > rowOfNumbers.Count - 1)
                    {
                        endIndex = rowOfNumbers.Count - 1;
                    }

                    rowOfNumbers.RemoveRange(startIndex, (endIndex - startIndex) + 1);
                    i = startIndex;
                }
            }
            Console.WriteLine(rowOfNumbers.Sum());
        }
    }
}
