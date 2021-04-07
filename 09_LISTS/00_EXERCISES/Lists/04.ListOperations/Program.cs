using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> rowOfInt = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse)
                                        .ToList();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmndArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToArray();
                switch (cmndArg[0])
                {
                    case "Add":
                        rowOfInt.Add(int.Parse(cmndArg[1]));
                        break;
                    case "Insert":
                        if (int.Parse(cmndArg[2]) >= rowOfInt.Count || int.Parse(cmndArg[2]) < 0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            rowOfInt.Insert(int.Parse(cmndArg[2]), int.Parse(cmndArg[1]));
                        }
                        break;
                    case "Remove":
                        if (int.Parse(cmndArg[1]) >= rowOfInt.Count || int.Parse(cmndArg[1]) < 0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            rowOfInt.RemoveAt(int.Parse(cmndArg[1]));
                        }
                        break;
                    case "Shift":
                        if (cmndArg[1] == "left")
                        {

                            for (int i = 0; i < int.Parse(cmndArg[2]); i++)
                            {
                                int firstElement = rowOfInt[0];
                                for (int j = 0; j < rowOfInt.Count - 1; j++)
                                {
                                    rowOfInt[j] = rowOfInt[j + 1];
                                }
                                rowOfInt[rowOfInt.Count - 1] = firstElement;
                            }
                        }
                        else
                        {

                            for (int i = 0; i < int.Parse(cmndArg[2]); i++)
                            {
                                int lastElement = rowOfInt[rowOfInt.Count - 1];
                                for (int j = rowOfInt.Count - 1; j > 0; j--)
                                {
                                    rowOfInt[j] = rowOfInt[j - 1];
                                }
                                rowOfInt[0] = lastElement;
                            }
                        }
                        break;

                    default:
                        break;
                }

                command = Console.ReadLine();  
            }
            Console.WriteLine(string.Join(" ", rowOfInt));
        }
    }
}
