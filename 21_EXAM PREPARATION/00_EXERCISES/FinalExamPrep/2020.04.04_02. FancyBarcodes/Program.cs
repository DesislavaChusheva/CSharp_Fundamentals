using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _2020._04._04_02._FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(@#{1,})([A-Z][A-Za-z0-9]{4,}[A-Z])(@#{1,})";
            Regex regex = new Regex(pattern);
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match barcode = regex.Match(input);
                if (barcode.Success)
                {
                    string productGroup = string.Empty;
                    char[] barcodechars = barcode.ToString().ToCharArray();
                    for (int j = 0; j < barcodechars.Length; j++)
                    {
                        if (char.IsDigit(barcodechars[j]))
                        {
                            productGroup += barcodechars[j];
                        }
                    }
                    if (productGroup.Length == 0)
                    {
                        productGroup = "00";
                    }

                   Console.WriteLine($"Product group: {productGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
