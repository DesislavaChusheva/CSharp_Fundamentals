using System;

namespace _01.SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmployee = int.Parse(Console.ReadLine());
            int secondEmployee = int.Parse(Console.ReadLine());
            int thirdEmployee = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());

            int studentsPerHour = firstEmployee + secondEmployee + thirdEmployee;
            int hoursCounter = 0;

            while (students > 0)
            {
                hoursCounter++;
                if (hoursCounter %4 == 0)
                {
                    continue;
                }
                students -= studentsPerHour;
            }
            Console.WriteLine($"Time needed: {hoursCounter}h.");

        }
    }
}
