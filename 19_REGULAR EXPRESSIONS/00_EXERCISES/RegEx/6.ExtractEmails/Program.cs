using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _6.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))(([A-Za-z\d]+[.\-_]?[A-Za-z\d]+)@([A-Za-z\d]+-?[A-Za-z\d]+(\.[A-Za-z\d]+-?[A-Za-z\d]+)+))";
            Regex regex = new Regex(pattern);
            string input = Console.ReadLine();
            MatchCollection matches = regex.Matches(input);
            Console.WriteLine(string.Join("\n",matches));
        }
    }
}
