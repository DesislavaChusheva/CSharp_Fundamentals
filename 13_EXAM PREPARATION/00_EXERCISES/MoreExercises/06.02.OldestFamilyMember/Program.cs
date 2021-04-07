using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._02.OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family theFamily = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person member = new Person(name, age);
                theFamily.AddMember(member);
            }
            if (theFamily.members.Count > 0)
            {
                Person theOldestMember = theFamily.GetOldestMember();
                Console.WriteLine($"{theOldestMember.Name} {theOldestMember.Age}");
            }
        }
    }
    public class Person
    {
        public Person() { }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }
    }
    public class Family
    {
        public Family() 
        {
            this.members = new List<Person>();
        }
        public List<Person> members = new List<Person>();
        public void AddMember(Person member)
        {
            members.Add(member);
        }
        public Person GetOldestMember()
        {
            var oldestPerson = members.OrderByDescending(x => x.Age).FirstOrDefault();
            return oldestPerson;
        }
    }
}

