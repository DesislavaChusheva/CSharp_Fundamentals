using System;

namespace _06.TriplesofLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        char iToChar = (char)(i + 97);
                        char jToChar = (char)(j + 97);
                        char kToChar = (char)(k + 97);

                        Console.WriteLine($"{iToChar}{jToChar}{kToChar}");

                    }
                }
            }
        }
    }
}
