using System;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int strenght = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    strenght += int.Parse(input[i + 1].ToString());
                }
                if (strenght > 0 && input[i] != '>')
                {
                    input = input.Remove(i, 1);
                    strenght--;
                    i--;
                }
            }
            Console.WriteLine(input);
        }
    }
}
