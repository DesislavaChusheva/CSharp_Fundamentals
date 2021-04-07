using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _4.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string decryptionPattern = @"[^SsTtAaRr]";
            string messagePattern = @"@([A-z]+)[^@\-!:>]?:(\d+)[^@\-!:>]?!([AD])![^@\-!:>]?->(\d+)";
            Regex regexMesagge = new Regex(messagePattern);

            int countAttackedPlanets = 0;
            int countDestroyedPlanets = 0;
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string message = Console.ReadLine();
                string decryption = Regex.Replace(message, decryptionPattern, "");
                int key = decryption.Length;
                char[] messageChar = message.ToCharArray();

                for (int j = 0; j < message.Length; j++)
                {
                    char currCh = message[j];
                    char replaceCh = (char)(currCh - key);
                    messageChar[j] = replaceCh;

                }
                string arrayToStr = new string(messageChar);
                Match finalMessage = regexMesagge.Match(arrayToStr);

                if (finalMessage.Success)
                {
                    string planetName = finalMessage.Groups[1].Value;
                    char attackType = char.Parse(finalMessage.Groups[3].Value);

                    if (attackType == 'A')
                    {
                        countAttackedPlanets++;
                        attackedPlanets.Add(planetName);
                    }
                    else
                    {
                        countDestroyedPlanets++;
                        destroyedPlanets.Add(planetName);
                    }
                }
            }
            Console.WriteLine($"Attacked planets: {countAttackedPlanets}");
            if (countAttackedPlanets > 0)
            {
                foreach (string planet in attackedPlanets.OrderBy(x => x))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
            Console.WriteLine($"Destroyed planets: {countDestroyedPlanets}");
            if (countDestroyedPlanets > 0)
            {
                foreach (string planet in destroyedPlanets.OrderBy(x => x))
                {
                    Console.WriteLine($"-> {planet}");
                }
            }
        }
    }
}
