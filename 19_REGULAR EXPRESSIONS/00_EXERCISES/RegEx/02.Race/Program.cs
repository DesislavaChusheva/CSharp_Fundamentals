using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string lettersPattern = @"[\W\d]";
            string digitsPattern = @"[\WA-z]";

            string[] participants = Console.ReadLine().Split(", ");
            Dictionary<string, int> participantsAndScore = new Dictionary<string, int>();
            foreach (var participant in participants)
            {
                participantsAndScore.Add(participant, 0);
            }

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string name = Regex.Replace(input, lettersPattern, "");
                if (participantsAndScore.ContainsKey(name))
                {
                    string distance = Regex.Replace(input, digitsPattern, "");
                    int sum = 0;
                    foreach (var digit in distance)
                    {
                        sum += int.Parse(digit.ToString());
                    }
                    participantsAndScore[name] += sum;
                }

                input = Console.ReadLine();
            }

            int count = 1;
            foreach (var kvp in participantsAndScore.OrderByDescending(x => x.Value))
            {
                string text = count == 1 ? "st" : count == 2 ? "nd" : "rd";
                Console.WriteLine($"{count++}{text} place: {kvp.Key}");
                if (count == 4)
                {
                    break;
                }
            }
        }
    }
}
