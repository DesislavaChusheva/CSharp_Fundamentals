using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            while (command != "end")
            {
                string[] arguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (arguments[0])
                {
                    case "Chat":
                        sb.AppendLine(arguments[1]);
                        break;

                    case "Delete":
                        string textToRemove = arguments[1];
                        int indexOfTextToRemove = sb.ToString().IndexOf(textToRemove);
                        if (indexOfTextToRemove == 0)
                        {
                            sb.Remove(indexOfTextToRemove, textToRemove.Length);
                        }
                        else
                        {
                            sb.Remove(indexOfTextToRemove - 1, textToRemove.Length + 1);
                        }
                        break;

                    case "Edit":
                        sb.Replace(arguments[1], arguments[2]);
                        break;

                    case "Pin":
                        string textToMove = arguments[1];
                        int indexOfTextToMove = sb.ToString().IndexOf(textToMove);
                        if (indexOfTextToMove == 0)
                        {
                            sb.Remove(indexOfTextToMove, textToMove.Length);
                        }
                        else
                        {
                            sb.Remove(indexOfTextToMove - 1, textToMove.Length + 1);
                        }
                        sb.AppendLine(textToMove);
                        break;

                    case "Spam":
                        for (int i = 1; i < arguments.Length; i++)
                        {
                            sb.AppendLine(arguments[i]);
                        }
                        break;


                    default:
                        break;
                }

                command = Console.ReadLine();
            }
            string resultString = Regex.Replace(sb.ToString(), @"^\s*$\n|\r", string.Empty, RegexOptions.Multiline).Trim();
            Console.WriteLine(resultString);
        }
    }
}
