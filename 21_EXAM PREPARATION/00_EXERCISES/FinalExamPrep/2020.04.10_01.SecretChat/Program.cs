using System;
using System.Linq;

namespace _2020._04._10_01.SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                string[] cmdArg = command.Split(":|:");
                string action = cmdArg[0];

                switch (action)
                {
                    case "InsertSpace":
                        message = message.Insert(int.Parse(cmdArg[1]), " ");
                        Console.WriteLine(message);
                        break;

                    case "Reverse":
                        string substring = cmdArg[1];
                        if (message.Contains(substring))
                        {
                            int index = message.IndexOf(substring);
                            message = message.Remove(index, substring.Length);
                            char[] array = substring.ToCharArray();
                            Array.Reverse(array);
                            string newSubstring = string.Empty;
                            for (int i = 0; i < array.Length; i++)
                            {
                                newSubstring += array[i];
                            }
                            message += newSubstring;
                            Console.WriteLine(message);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;

                    case "ChangeAll":
                        message = message.Replace(cmdArg[1], cmdArg[2]);
                        Console.WriteLine(message);
                        break;

                    default:
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
