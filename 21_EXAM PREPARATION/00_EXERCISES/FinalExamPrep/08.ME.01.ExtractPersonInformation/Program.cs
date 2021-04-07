using System;
using System.Linq;

namespace _08.ME._01.ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                string name = string.Empty;
                string age = string.Empty;
                int nameStart = text.IndexOf('@') + 1;
                int nameEnd = text.IndexOf('|');
                int ageStart = text.IndexOf('#') + 1;
                int ageEnd = text.IndexOf('*');

                name = text.Substring(nameStart, nameEnd - nameStart);
                age = text.Substring(ageStart, ageEnd - ageStart);
                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
