using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            Console.WriteLine(VowelsCounter(text));
        }

        private static int VowelsCounter(string text)
        {
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char currLetter = text[i];
                switch (currLetter)
                {
                    case 'a':
                    case 'e':
                    case 'o':
                    case 'i':
                    case 'u':
                    case 'y':
                        counter++;
                        break;
                    default:
                        break;
                }
            }
            return counter;
        }
    }
}
