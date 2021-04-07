using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _2020._04._10_02.MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"([@|#])([A-Za-z]{3,})\1\1([A-Za-z]{3,})\1";
            Regex regex = new Regex(pattern);
            List<string> mirrorWords = new List<string>();

            var matches = regex.Matches(text);
            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
                foreach (Match match in matches)
                {
                    string firstString = match.Groups[2].Value;
                    string secondString = match.Groups[3].Value;
                    char[] second = secondString.ToCharArray();
                    Array.Reverse(second);
                    string secondStringReversed = new string(second);

                    if (firstString == secondStringReversed)
                    {
                        mirrorWords.Add($"{firstString} <=> {secondString}");
                    }
                }
                if (mirrorWords.Count > 0)
                {
                    Console.WriteLine("The mirror words are:");
                    Console.WriteLine(string.Join(", ", mirrorWords));
                }
                else
                {
                    Console.WriteLine("No mirror words!");
                }
            }
        }
    }
}
