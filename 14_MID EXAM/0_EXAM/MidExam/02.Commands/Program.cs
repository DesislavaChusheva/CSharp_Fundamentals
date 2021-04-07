using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Commands
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .ToArray();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] arguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (arguments[0] == "reverse")
                {
                    int start = int.Parse(arguments[2]);
                    int count = int.Parse(arguments[4]);
                    int[] subArray = new int[count];
                    int subArrayEndIndex = count - 1;
                    int subArrayStartIndex = 0;

                    for (int i = start; i < start + count; i++)
                    {
                        subArray[subArrayEndIndex] = array[i];
                        subArrayEndIndex--;
                    }

                    for (int i = start; i < start + count; i++)
                    {
                        array[i] = subArray[subArrayStartIndex];
                        subArrayStartIndex++;
                    }
                }
                else if (arguments[0] == "sort")
                {
                    int start = int.Parse(arguments[2]);
                    int count = int.Parse(arguments[4]);
                    int[] subArray = new int[count];
                    int subArrayStartIndex = 0;

                    for (int i = start; i < start + count; i++)
                    {
                        subArray[subArrayStartIndex] = array[i];
                        subArrayStartIndex++;
                    }
                    Array.Sort<int>(subArray);
                    subArrayStartIndex = 0;

                    for (int i = start; i < start + count; i++)
                    {
                        array[i] = subArray[subArrayStartIndex];
                        subArrayStartIndex++;
                    }
                }
                else
                {
                    List<int> shorten = array.ToList();
                    shorten.RemoveRange(0, int.Parse(arguments[1]));
                    array = shorten.ToArray();
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",array));
        }
    }
}
