using System;

namespace _03_Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string typeOfPeople = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();


            double totalPrice = 0.00;

            switch (typeOfPeople)
            {
                case "Students":
                    switch (dayOfTheWeek)
                    {
                        case "Friday":
                            totalPrice = 8.45 * peopleCount;
                            break;
                        case "Saturday":
                            totalPrice = 9.80 * peopleCount;
                            break;
                        case "Sunday":
                            totalPrice = 10.46 * peopleCount;
                            break;
                        default:
                            break;
                    }
                    if (peopleCount >= 30)
                    {
                        totalPrice *= 0.85;
                    }
                    break;
                case "Business":
                    switch (dayOfTheWeek)
                    {
                        case "Friday":
                            totalPrice = 10.90 * peopleCount;
                            break;
                        case "Saturday":
                            totalPrice = 15.60 * peopleCount;
                            break;
                        case "Sunday":
                            totalPrice = 16.00 * peopleCount;
                            break;
                        default:
                            break;
                    }
                    if (peopleCount >= 100)
                    {
                        totalPrice *= 0.90;
                    }
                    break;
                case "Regular":
                    switch (dayOfTheWeek)
                    {
                        case "Friday":
                            totalPrice = 15.00 * peopleCount;
                            break;
                        case "Saturday":
                            totalPrice = 20.00 * peopleCount;
                            break;
                        case "Sunday":
                            totalPrice = 22.50 * peopleCount;
                            break;
                        default:
                            break;
                    }
                    if (peopleCount >= 10 && peopleCount <= 20)
                    {
                        totalPrice *= 0.95;
                    }
                    break;

                default:
                    break;
            }

            Console.WriteLine($"Total price: {totalPrice}");
        }
    }
}
