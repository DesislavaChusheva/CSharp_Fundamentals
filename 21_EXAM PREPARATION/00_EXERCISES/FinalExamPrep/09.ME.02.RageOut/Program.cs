using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _09.ME._02.RageOut
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([.\D]+)(\d+)";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
            MatchCollection matches = regex.Matches(input);
            List<char> symbols = new List<char>();

            StringBuilder sb = new StringBuilder();

            foreach (Match match in matches)
            {
                int repeat = int.Parse(match.Groups[2].Value.ToString());
                for (int i = 0; i < repeat; i++)
                {
                    sb.Append(match.Groups[1].Value.ToString().ToUpper());
                }
                if (repeat > 0)
                {
                    for (int i = 0; i < match.Groups[1].Length; i++)
                    {
                        if (!symbols.Contains(match.Groups[1].ToString().ToLower()[i]))
                        {
                            symbols.Add(match.Groups[1].ToString().ToLower()[i]);
                        }
                    }
                }
            }
            Console.WriteLine($"Unique symbols used: {symbols.Count}");
            Console.WriteLine(sb.ToString());
        }
    }
}
