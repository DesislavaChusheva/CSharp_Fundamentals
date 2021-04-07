using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> rowOfInt = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse)
                                        .ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] cmndArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (cmndArg[0] == "Insert")
                {
                    rowOfInt.Insert(int.Parse(cmndArg[2]), int.Parse(cmndArg[1]));
                }
                else
                {
                    rowOfInt.RemoveAll(x => x == int.Parse(cmndArg[1]));
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", rowOfInt));
        }
    }
}
