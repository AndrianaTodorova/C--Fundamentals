using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CompanyRoster
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var employees = GetEmployees();
            var higsestSalary = employees.GroupBy(e => e.Department)
                .OrderByDescending(e => e.Select(g => g.Salary).Sum())
                .First();


            Console.WriteLine($"Highest Average Salary: {higsestSalary.Key}");
            Console.WriteLine(string.Join(Environment.NewLine, higsestSalary
                .OrderByDescending(e => e.Salary)
                .Select(e => $"{e.Name} {e.Salary:F2} {e.Email} {e.Age}")));


        }
        private static Stack<Employee> GetEmployees()
        {
            var employees = new Stack<Employee>();
            var numberOfEmployees = int.Parse(Console.ReadLine());

            while (employees.Count < numberOfEmployees)
            {
                var email = "n/a";
                var age = -1;
                var personData = Console.ReadLine().Split();

                if (personData.Length > 4)
                {
                    int parsed;
                    var isdigit = int.TryParse(personData[4], out parsed);

                    if (isdigit)
                    {
                        age = parsed;
                    }
                    else
                    {
                        email = personData[4];
                    }

                    if (personData.Length > 5)
                    {
                        if (isdigit)
                        {
                            email = personData[5];
                        }
                        else
                        {
                            age = int.Parse(personData[5]);
                        }
                    }
                }

                employees.Push(new Employee(
                    personData[0],
                    double.Parse(personData[1]),
                    personData[2],
                    personData[3],
                    email,
                    age
                ));
            }

            return employees;
        }
    }
}
