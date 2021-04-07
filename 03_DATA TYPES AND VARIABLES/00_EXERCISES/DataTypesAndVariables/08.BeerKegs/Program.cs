using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double biggestVolume = 0;
            string biggestKegName = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string beerKegName = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                double hight = double.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * hight;

                if (volume > biggestVolume)
                {
                    biggestVolume = volume;
                    biggestKegName = beerKegName;

                }

            }
            Console.WriteLine(biggestKegName);
        }
    }
}
