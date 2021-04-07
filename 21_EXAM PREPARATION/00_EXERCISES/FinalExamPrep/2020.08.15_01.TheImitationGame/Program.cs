using System;

namespace _2020._08._15_01.TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Decode")
            {
                string[] cmdArg = command.Split('|', StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArg[0];
                switch (action)
                {
                    case "Move":
                        int n = int.Parse(cmdArg[1]);
                        string substring = message.Substring(0, n);
                        message = message.Remove(0, n);
                        message += substring;
                        break;

                    case "Insert":
                        int index = int.Parse(cmdArg[1]);
                        string value = cmdArg[2];
                        message = message.Insert(index, value);
                        break;

                    case "ChangeAll":
                        string oldSubstring = cmdArg[1];
                        string replacment = cmdArg[2];
                        message = message.Replace(oldSubstring, replacment);
                        break;

                    default:
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
