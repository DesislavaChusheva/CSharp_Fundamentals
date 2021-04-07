using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> companyAndEmployeePair = new Dictionary<string, List<string>>();

            while (input != "End")
            {
                string[] arguments = input.Split(" -> ").ToArray();
                string companyName = arguments[0];
                string employeeId = arguments[1];

                if (!companyAndEmployeePair.ContainsKey(companyName))
                {
                    List<string> Ids = new List<string>();
                    Ids.Add(employeeId);
                    companyAndEmployeePair.Add(companyName, Ids);
                }
                else
                {
                    if (!companyAndEmployeePair[companyName].Contains(employeeId))
                    {
                        companyAndEmployeePair[companyName].Add(employeeId);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var company in companyAndEmployeePair.OrderBy(x => x.Key))
            {
                Console.WriteLine(company.Key);

                foreach (var id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
