using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            if (!PasswordLenght(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!OnlyLettersAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!AtLeastTwoDigits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (PasswordLenght(password) && OnlyLettersAndDigits(password) && AtLeastTwoDigits(password))
            {
                Console.WriteLine("Password is valid");
            }

        }
        static public bool PasswordLenght (string pass)
        {
            if (pass.Length > 5 && pass.Length < 11)
            {
                return true;
            }
            return false;
        }
        static public bool OnlyLettersAndDigits (string pass)
        {
            foreach (char item in pass)
            {
                if (!char.IsLetterOrDigit(item))
                {
                    return false;
                }
            }

            return true;
        }
        static public bool AtLeastTwoDigits (string pass)
        {
            int counter = 0;
            foreach (char item in pass)
            {
                if (char.IsDigit(item))
                {
                    counter++;
                }
            }
            if (counter > 1)
            {
                return true;
            }
            return false;
        }
    }
}
