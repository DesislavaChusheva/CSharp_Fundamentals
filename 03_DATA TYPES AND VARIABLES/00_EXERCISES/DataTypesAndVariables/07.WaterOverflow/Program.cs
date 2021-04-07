using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            byte collectedLiters = 0;

            for (int i = 0; i < n; i++)
            {
                short input = short.Parse(Console.ReadLine());

                if (input > (255 - collectedLiters))
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                else
                {
                    collectedLiters += (byte)input;
                }
            }

            Console.WriteLine(collectedLiters);

        }
    }
}
