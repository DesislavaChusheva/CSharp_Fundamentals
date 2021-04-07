using System;
using System.Linq;

namespace _2020._04._04_01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Generate")
            {
                string[] cdArgs = command.Split(">>>");

                switch (cdArgs[0])
                {
                    case "Contains":
                        if (key.Contains(cdArgs[1]))
                        {
                            Console.WriteLine($"{key} contains {cdArgs[1]}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;

                    case "Flip":
                        int startIndex = int.Parse(cdArgs[2]);
                        int endIndex = int.Parse(cdArgs[3]);
                        string start = key.Substring(0, startIndex);
                        string substring = key.Substring(startIndex, endIndex - startIndex);
                        string end = key.Substring(endIndex);

                        if (cdArgs[1].ToLower() == "lower")
                        {
                            substring = substring.ToLower();
                        }
                        else
                        {
                            substring = substring.ToUpper();
                        }

                        key = start + substring + end;
                        Console.WriteLine(key);
                        break;

                    case "Slice":
                        key = key.Remove(int.Parse(cdArgs[1]), int.Parse(cdArgs[2]) - int.Parse(cdArgs[1]));
                        Console.WriteLine(key);
                        break;

                    default:
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {key}");
        }
    }
}
