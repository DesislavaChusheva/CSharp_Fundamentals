using System;

namespace _07_VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0.0;

            while (input!="Start")
            {
                double coin = double.Parse(input);
                if (coin != 0.1 && coin != 0.2 && coin != 0.5 && coin != 1.0 && coin != 2.0)
                {
                    Console.WriteLine($"Cannot accept {input}");
                    input = Console.ReadLine();
                    if (input == "Start")
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    sum += coin;
                }
                input = Console.ReadLine();
            }
            string product = Console.ReadLine();
            double finalPrice = 0.0;

            while (product != "End")
            {
                double productPrice = 0.0;
                switch (product)
                {
                    case "Nuts":
                        finalPrice += 2.0;
                        productPrice = 2.0;
                        break;
                    case "Water":
                        finalPrice += 0.7;
                        productPrice = 0.7;
                        break;
                    case "Crisps":
                        finalPrice += 1.5;
                        productPrice = 1.5;
                        break;
                    case "Soda":
                        finalPrice += 0.8;
                        productPrice = 0.8;
                        break;
                    case "Coke":
                        finalPrice += 1.0;
                        productPrice = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                if (finalPrice > sum)
                {
                    Console.WriteLine("Sorry, not enough money");
                    finalPrice -= productPrice;
                    break;
                }
                else
                {
                    Console.WriteLine($"Purchased {product.ToLower}");
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {(sum - finalPrice):f2}");
        }
    }
}
