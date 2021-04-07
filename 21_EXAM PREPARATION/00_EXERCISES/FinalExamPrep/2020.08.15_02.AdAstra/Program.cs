using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _2020._08._15_02.AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\||#)([A-Za-z\s]+)\1([\d]{2}\/[\d]{2}\/[\d]{2})\1([\d]{0,5})\1";
            Regex regex = new Regex(pattern);
            Dictionary<string, Food> products = new Dictionary<string, Food>();
            MatchCollection matches = regex.Matches(Console.ReadLine());
            int allCalories = 0;

            foreach (Match match in matches)
            {
                Food product = new Food(match.Groups[3].Value, int.Parse(match.Groups[4].Value));
                products.Add(match.Groups[2].Value, product);
                allCalories += int.Parse(match.Groups[4].Value);
            }
            int daysLeft = allCalories / 2000;
            Console.WriteLine($"You have food to last you for: {daysLeft} days!");
            if (daysLeft > 0)
            {
                foreach (var product in products)
                {
                    Console.WriteLine($"Item: {product.Key}, Best before: {product.Value.Date}, Nutrition: {product.Value.Calories}");
                }
            }
        }

        class Food
        {
            public Food(string date, int calories)
            {
                Date = date;
                Calories = calories;
            }
            public string Date { get; set; }
            public int Calories { get; set; }
        }
    }
}
