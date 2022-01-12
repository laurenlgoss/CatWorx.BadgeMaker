using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        // Return list of employees inputted by user
        static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            while (true)
            {
                Console.WriteLine("Please enter a name (leavy empty to exit):");
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                Employee employee = new Employee(input, "Smith");
                employees.Add(employee);
            }
            return employees;
        }
        // Prints inputted employee list to CLI
        static void PrintEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i].GetName());
            }
        }
        // Entry point for application
        static void Main(string[] args)
        {
            List<Employee> employees = GetEmployees();
            PrintEmployees(employees);
        }
    }
}