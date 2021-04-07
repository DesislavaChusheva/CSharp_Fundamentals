using System;

namespace _01.CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int winsCounter = 0;
            bool lost = false;

            while (input != "End of battle")
            {
                if (winsCounter % 3 == 0)
                {
                    initialEnergy += winsCounter;
                }
                int distance = int.Parse(input);
                if (initialEnergy >= distance)
                {
                    initialEnergy -= distance;
                    winsCounter++;
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {winsCounter} won battles and {initialEnergy} energy");
                    lost = true;
                    break;
                }

                input = Console.ReadLine();
            }

            if (!lost)
            {
                Console.WriteLine($"Won battles: {winsCounter}. Energy left: {initialEnergy}");
            }
        }
    }
}
