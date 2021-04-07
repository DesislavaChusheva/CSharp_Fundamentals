using System;
using System.Linq;

namespace _02.ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();
            string input = Console.ReadLine();
            int shootsCount = 0;

            while (input != "End")
            {
                int shootIndex = int.Parse(input);
                if (shootIndex > targets.Length - 1 || shootIndex < 0)
                {
                    input = Console.ReadLine();
                    continue;
                }
                if (targets[shootIndex] == -1)
                {
                    input = Console.ReadLine();
                    continue;
                }

                shootsCount++;
                int shootNumber = targets[shootIndex];
                targets[shootIndex] = -1;

                for (int i = 0; i < targets.Length; i++)
                {
                    if (targets[i] != -1)
                    {
                        if (targets[i] > shootNumber)
                        {
                            targets[i] -= shootNumber;
                        }
                        else
                        {
                            targets[i] += shootNumber;
                        }
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Shot targets: {shootsCount} -> {string.Join(" ", targets)}");
        }
    }
}
