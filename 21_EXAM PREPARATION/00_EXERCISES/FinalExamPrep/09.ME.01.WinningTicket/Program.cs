using System;
using System.Text.RegularExpressions;

namespace _09.ME._01.WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([@|#|$|^]{6,10})";
            Regex regex = new Regex(pattern);

            char[] delimiterChars = { ',', ' ' };
            string[] input = Console.ReadLine().Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

            foreach (var ticket in input)
            {
                if (ticket.Length == 20)
                {
                    string leftHalf = ticket.Substring(0, 10);
                    string rightHalf = ticket.Substring(10, 10);

                    Match leftMatch = regex.Match(leftHalf);
                    Match rightMatch = regex.Match(rightHalf);

                    if (!leftMatch.Success || !rightMatch.Success)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                        continue;
                    }

                    else
                    {
                        string shorter = leftMatch.Value;
                        if (leftMatch.Value.Length > rightMatch.Value.Length)
                        {
                            shorter = rightMatch.Value;
                        }

                        if (shorter.Length == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {shorter.Length}{shorter[0]} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {shorter.Length}{shorter[0]}");
                        }

                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
