using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Commands02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                                        .Split()
                                        .ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] arguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (arguments[0] == "reverse")
                {
                    int start = int.Parse(arguments[2]);
                    int count = int.Parse(arguments[4]);
                    List<string> subList = input.GetRange(start, count);
                    subList.Reverse();
                    input.RemoveRange(start, count);
                    input.InsertRange(start, subList);
                }
                else if (arguments[0] == "sort")
                {
                    int start = int.Parse(arguments[2]);
                    int count = int.Parse(arguments[4]);
                    List<string> subList = input.GetRange(start, count);
                    subList.Sort();
                    input.RemoveRange(start, count);
                    input.InsertRange(start, subList);
                }
                else
                {
                    input.RemoveRange(0, int.Parse(arguments[1]));
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",input));
        }
    }
}
