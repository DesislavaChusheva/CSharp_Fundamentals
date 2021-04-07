using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] arguments = input
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();
                string command = arguments[0];
                int index = int.Parse(arguments[1]);
                int value = int.Parse(arguments[2]);

                if (index < 0 || index >= targets.Count)
                {
                    if (command == "Add")
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                    if (command == "Strike")
                    {
                        Console.WriteLine("Strike missed!");
                    }
                    input = Console.ReadLine();
                    continue;
                }

                switch (command)
                {
                    case "Shoot":
                        if (targets[index] - value > 0)
                        {
                            targets[index] -= value;
                        }
                        else
                        {
                            targets.RemoveAt(index);
                        }
                        break;
                    case "Add":
                        targets.Insert(index, value);
                        break;
                    case "Strike":
                        if (index - value >= 0 && index + value < targets.Count)
                        {
                            targets.RemoveRange(index - value, 2 * value + 1);
                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                        }
                        break;

                    default:
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join("|", targets));
        }

    }
}
