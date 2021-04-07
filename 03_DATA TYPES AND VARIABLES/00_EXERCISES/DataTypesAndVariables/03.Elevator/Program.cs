using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            int coursesCounter = 0;

            while (n > 0)
            {
                coursesCounter++;
                n -= p;
            }
            Console.WriteLine(coursesCounter);
        }
    }
}
