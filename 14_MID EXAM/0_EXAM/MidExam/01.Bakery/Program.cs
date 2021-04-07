using System;

namespace _01.Bakery
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitsWorkerPerDay = int.Parse(Console.ReadLine());
            int countOfWorkers = int.Parse(Console.ReadLine());
            int bCompetingFactory30Days = int.Parse(Console.ReadLine());

            int biscuitsPerDay = biscuitsWorkerPerDay * countOfWorkers;
            double biscuitsPerThirdDay = Math.Floor(biscuitsPerDay * 0.75);
            
            double sumOfBiscuits = 0;
            for (int i = 1; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    sumOfBiscuits += biscuitsPerThirdDay;
                }
                else
                {
                    sumOfBiscuits += biscuitsPerDay;
                }
            }
            Console.WriteLine($"You have produced {sumOfBiscuits} biscuits for the past month.");
            double diference = (Math.Abs(sumOfBiscuits - bCompetingFactory30Days) / bCompetingFactory30Days) * 100;

            if (sumOfBiscuits > bCompetingFactory30Days)
            {
                Console.WriteLine($"You produce {diference:f2} percent more biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {diference:f2} percent less biscuits.");
            }
        }
    }
}
