using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ActivationKey
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Generate")
            {
                List<string> arguments = command.Split(">>>", StringSplitOptions.RemoveEmptyEntries).ToList();

                switch (arguments[0])
                {
                    case "Contains":
                        if (input.Contains(arguments[1]))
                        {
                            Console.WriteLine($"{input} contains {arguments[1]}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;

                    case "Flip":
                        string substring = input.Substring(int.Parse(arguments[2]), int.Parse(arguments[3]) - int.Parse(arguments[2]));
                        string newSubstring = substring;

                        if (arguments[1] == "Upper")
                        {
                            newSubstring = substring.ToUpper();
                        }
                        else
                        {
                            newSubstring = substring.ToLower();
                        }
                        input = input.Replace(substring, newSubstring);
                        Console.WriteLine(input);
                        break;

                    case "Slice":
                        input = input.Remove(int.Parse(arguments[1]), int.Parse(arguments[2]) - int.Parse(arguments[1]));
                        Console.WriteLine(input);
                        break;

                    default:
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {input}");
        }
    }
}
