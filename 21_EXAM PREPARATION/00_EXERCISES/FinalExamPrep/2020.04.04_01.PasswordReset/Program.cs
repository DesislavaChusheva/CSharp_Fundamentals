using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2020._04._04_01.PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder password = new StringBuilder();
            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] cmdArg = command.Split();
                switch (cmdArg[0])
                {
                    case "TakeOdd":
                        for (int i = 0; i < input.Length; i++)
                        {
                            if (i%2 != 0)
                            {
                                password.Append(input[i]);
                            }
                        }
                        input = password.ToString();
                        Console.WriteLine(input);
                        break;

                    case "Cut":
                        input = input.Remove(int.Parse(cmdArg[1]), int.Parse(cmdArg[2]));
                        Console.WriteLine(input);
                        break;

                    case "Substitute":
                        string substring = cmdArg[1];
                        string replasment = cmdArg[2];
                        if (!input.Contains(substring))
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        else
                        {
                            input = input.Replace(substring, replasment);
                            Console.WriteLine(input);
                        }
                        break;

                    default:
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {input}");
        }
    }
}
