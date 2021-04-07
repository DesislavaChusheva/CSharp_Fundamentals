using System;

namespace _02.EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int coolThreashold = 0;

            foreach (var item in input)
            {
                int number;
                bool isNumber = int.TryParse(item, out number);
                if (isNumber)
                {
                    coolThreashold += item;
                }
            }
            Console.WriteLine(coolThreashold);
        }
    }
}
