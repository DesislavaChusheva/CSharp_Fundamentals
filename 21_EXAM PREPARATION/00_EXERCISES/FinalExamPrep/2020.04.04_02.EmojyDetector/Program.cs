using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _2020._04._04_02.EmojyDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(::|\*\*)([A-Z][a-z]{2,})\1";
            string digitsPattern = @"\d";
            Regex findDigits = new Regex(digitsPattern);
            Regex findEmojies = new Regex(pattern);

            string input = Console.ReadLine();

            long coolTreshold = 1;
            findDigits.Matches(input).Select(d => d.Value)
                                     .Select(int.Parse)
                                     .ToList()
                                     .ForEach(x => coolTreshold *= x);

            MatchCollection emojies = findEmojies.Matches(input);
            int emojiesCount = emojies.Count;
            List<string> coolEmojies = new List<string>();

            foreach (Match emojie in emojies)
            {
                char[] chEm = emojie.Groups[2].ToString().ToCharArray();
                int treshold = emojie.Groups[2].Value.ToCharArray().Sum(x => (int)x);

                if (treshold > coolTreshold)
                {
                    coolEmojies.Add(emojie.Value);
                }
            }
            Console.WriteLine($"Cool threshold: {coolTreshold}");
            Console.WriteLine($"{emojiesCount} emojis found in the text. The cool ones are:");
            foreach (var emojie in coolEmojies)
            {
                Console.WriteLine(emojie);
            }
        }
    }
}
