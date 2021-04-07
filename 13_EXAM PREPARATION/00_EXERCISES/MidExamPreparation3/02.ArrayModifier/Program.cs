using System;
using System.Linq;

namespace _02.ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] arguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (arguments[0])
                {
                    case "swap":
                        int firstItem = array[int.Parse(arguments[1])];
                        int secondItem = array[int.Parse(arguments[2])];
                        array[int.Parse(arguments[1])] = secondItem;
                        array[int.Parse(arguments[2])] = firstItem;
                        break;

                    case "multiply":
                        array[int.Parse(arguments[1])] = array[int.Parse(arguments[1])] * array[int.Parse(arguments[2])];
                        break;

                    case "decrease":
                        for (int i = 0; i < array.Length; i++)
                        {
                            array[i]--;
                        }
                        break;

                    default:
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
