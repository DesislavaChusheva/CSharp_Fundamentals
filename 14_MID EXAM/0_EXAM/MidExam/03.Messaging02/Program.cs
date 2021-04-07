using System;
using System.Collections.Generic;

namespace _03.Messaging02
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            List<string> message = new List<string>();

            while (command != "end")
            {
                string[] arguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (arguments[0])
                {
                    case "Chat":
                        message.Add(arguments[1]);
                        break;

                    case "Delete":
                        message.Remove(arguments[1]);
                        break;

                    case "Edit":
                        int index = message.IndexOf(arguments[1]);
                        message.Remove(arguments[1]);
                        message.Insert(index, arguments[2]);
                        break;

                    case "Pin":
                        message.Remove(arguments[1]);
                        message.Add(arguments[1]);
                        break;

                    case "Spam":
                        for (int i = 1; i < arguments.Length; i++)
                        {
                            message.Add(arguments[i]);
                        }
                        break;


                    default:
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join("\n", message));
        }
    }
}
