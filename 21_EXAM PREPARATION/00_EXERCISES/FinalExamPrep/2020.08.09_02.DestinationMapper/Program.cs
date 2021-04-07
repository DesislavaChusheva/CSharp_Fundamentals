using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _2020._08._09_02.DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([=|\/])([A-Z][A-Za-z]{2,})\1";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
            MatchCollection matches = regex.Matches(input);
            List<string> destinations = new List<string>();
            int travelPoints = 0;

            foreach (Match match in matches)
            {
                string destination = match.Groups[2].ToString();
                destinations.Add(destination);
                travelPoints += destination.Length;
            }
            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
