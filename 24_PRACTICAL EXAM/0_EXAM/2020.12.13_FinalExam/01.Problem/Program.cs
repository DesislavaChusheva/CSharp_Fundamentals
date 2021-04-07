using System;
using System.Linq;

namespace _01.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] cmdArg = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArg[0];

                switch (action)
                {
                    case "Change":
                        string ch = cmdArg[1];
                        string replacment = cmdArg[2];
                        input = input.Replace(ch, replacment);
                        Console.WriteLine(input);
                        break;

                    case "Includes":
                        string str = cmdArg[1];
                        Console.WriteLine(input.Contains(str));
                        break;

                    case "End":
                        string endString = cmdArg[1];
                        Console.WriteLine(input.EndsWith(endString));
                        break;

                    case "Uppercase":
                        input = input.ToUpper();
                        Console.WriteLine(input);
                        break;

                    case "FindIndex":
                        string chFind = cmdArg[1];
                        Console.WriteLine(input.IndexOf(chFind));
                        break;

                    case "Cut":
                        int startIndex = int.Parse(cmdArg[1]);
                        int lenght = int.Parse(cmdArg[2]);
                        input = input.Substring(startIndex, lenght);
                        Console.WriteLine(input);
                        break;


                    default:
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
