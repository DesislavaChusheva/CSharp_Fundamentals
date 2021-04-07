using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentsAndGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsAndGrades.ContainsKey(name))
                {
                    List<double> grades = new List<double>();
                    grades.Add(grade);
                    studentsAndGrades.Add(name, grades);
                }
                else
                {
                    studentsAndGrades[name].Add(grade);
                }
            }

            foreach (var item in studentsAndGrades)
            {
                if (item.Value.Sum() / item.Value.Count < 4.50)
                {
                    studentsAndGrades.Remove(item.Key);
                }
            }

            foreach (var item in studentsAndGrades.OrderByDescending(x => x.Value.Sum() / x.Value.Count))
            {
                Console.WriteLine($"{item.Key} -> {(item.Value.Sum() / item.Value.Count):f2}");
            }
        }
    }
}
