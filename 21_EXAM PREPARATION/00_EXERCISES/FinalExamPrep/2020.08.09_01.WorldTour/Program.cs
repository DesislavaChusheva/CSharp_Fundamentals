using System;

namespace _2020._08._09_01.WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string tour = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Travel")
            {
                string[] cmdarg = command.Split(':', StringSplitOptions.RemoveEmptyEntries);
                string action = cmdarg[0];

                switch (action)
                {
                    case "Add Stop":
                        int index = int.Parse(cmdarg[1]);
                        string text = cmdarg[2];

                        if (index >= 0 && index < tour.Length)
                        {
                            tour = tour.Insert(index, text);
                        }
                        Console.WriteLine(tour);
                        break;

                    case "Remove Stop":
                        int startIndex = int.Parse(cmdarg[1]);
                        int endIndex = int.Parse(cmdarg[2]);
                        bool validStart = startIndex >= 0 && startIndex < tour.Length;
                        bool validEnd = endIndex >= 0 && endIndex < tour.Length;

                        if (validStart && validEnd)
                        {
                            tour = tour.Remove(startIndex, (endIndex - startIndex)+1);
                        }
                        Console.WriteLine(tour);
                        break;

                    case "Switch":
                        string oldString = cmdarg[1];
                        string newString = cmdarg[2];

                        if (tour.Contains(oldString))
                        {
                            tour = tour.Replace(oldString, newString);
                        }
                        Console.WriteLine(tour);
                        break;

                    default:
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {tour}");
        }
    }
}
