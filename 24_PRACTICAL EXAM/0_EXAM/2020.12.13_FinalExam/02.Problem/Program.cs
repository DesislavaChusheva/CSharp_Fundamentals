using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^([$|%])([A-Z][a-z]{2,})\1:\s\[(\d+)\]\|\[(\d+)\]\|\[(\d+)\]\|$";
            Regex regex = new Regex(pattern);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = regex.Match(input);
                if (match.Success)
                {
                    char char1 = (char)int.Parse(match.Groups[3].Value);
                    char char2 = (char)int.Parse(match.Groups[4].Value);
                    char char3 = (char)int.Parse(match.Groups[5].Value);
                    Console.WriteLine($"{match.Groups[2].Value}: {char1}{char2}{char3}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
