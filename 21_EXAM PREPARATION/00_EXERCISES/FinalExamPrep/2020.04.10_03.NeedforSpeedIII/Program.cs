using System;
using System.Collections.Generic;
using System.Linq;

namespace _2020._04._10_03.NeedforSpeedIII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                string[] inputCar = Console.ReadLine().Split('|');
                string car = inputCar[0];
                int mileage = int.Parse(inputCar[1]);
                int fuel = int.Parse(inputCar[2]);
                Car carData = new Car(mileage, fuel);
                cars.Add(car, carData);
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] cmdArg = command.Split(" : ");
                string action = cmdArg[0];
                string car = cmdArg[1];

                switch (action)
                {
                    case "Drive":
                        int distance = int.Parse(cmdArg[2]);
                        int fuel1 = int.Parse(cmdArg[3]);

                        if (cars[car].Fuel < fuel1)
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        else
                        {
                            cars[car].Mileage += distance;
                            cars[car].Fuel -= fuel1;
                            Console.WriteLine($"{car} driven for {distance} kilometers. {fuel1} liters of fuel consumed.");
                            if (cars[car].Mileage >= 100000)
                            {
                                Console.WriteLine($"Time to sell the {car}!");
                                cars.Remove(car);
                            }
                        }
                        break;

                    case "Refuel":
                        int fuel2 = int.Parse(cmdArg[2]);
                        if (cars[car].Fuel + fuel2 > 75)
                        {
                            fuel2 = 75 - cars[car].Fuel;
                        }
                        cars[car].Fuel += fuel2;
                        Console.WriteLine($"{car} refueled with {fuel2} liters");
                        break;

                    case "Revert":
                        int kilometers = int.Parse(cmdArg[2]);
                        if (cars[car].Mileage - kilometers <= 10000)
                        {
                            cars[car].Mileage = 10000;
                        }
                        else
                        {
                            cars[car].Mileage -= kilometers;
                            Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                        }
                        break;

                    default:
                        break;
                }

                command = Console.ReadLine();
            }
            foreach (var car in cars.OrderByDescending(c => c.Value.Mileage).ThenBy(c => c.Key))
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value.Mileage} kms, Fuel in the tank: {car.Value.Fuel} lt.");
            }
        }
        class Car
        {
            public Car (int mileage, int fuel)
            {
                Mileage = mileage;
                Fuel = fuel;
            }
            public int Mileage { get; set; }
            public int Fuel { get; set; }
        }
    }
}
