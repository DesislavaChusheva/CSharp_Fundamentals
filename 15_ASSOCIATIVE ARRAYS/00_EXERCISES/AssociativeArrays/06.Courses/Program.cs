using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            while (input != "end")
            {
                string[] courseStudentPair = input.Split(" : ").ToArray();
                string course = courseStudentPair[0];
                string student = courseStudentPair[1];

                if (!courses.ContainsKey(course))
                {
                    List<string> students = new List<string>();
                    students.Add(student);
                    courses.Add(course, students);
                }
                else
                {
                    courses[course].Add(student);
                }

                input = Console.ReadLine();
            }

            foreach (var course in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var student in course.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {string.Join(" ", student)}");
                }
            }
        }
    }
}
