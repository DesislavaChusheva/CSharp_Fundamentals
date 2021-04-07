using System;

namespace _05_Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = string.Empty;

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                password += userName[i];
            }

            string tryPass = Console.ReadLine();
            int wrongPssCounter = 0;

            while (true)
            {
                if (tryPass == password)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    break;
                }
                else
                {
                    wrongPssCounter++;
                    if (wrongPssCounter == 4)
                    {
                        Console.WriteLine($"User {userName} blocked!");
                        break;
                    }
                    Console.WriteLine("Incorrect password. Try again.");
                    tryPass = Console.ReadLine();
                }
            }
        }
    }
}
