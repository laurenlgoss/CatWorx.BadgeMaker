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
                Console.WriteLine("Enter first name (leavy empty to exit): ");
                string firstName = Console.ReadLine() ?? ""; // Return empty string if there is no input
                if (firstName == "")
                {
                    break;
                }

                Console.WriteLine("Enter last name: ");
                string lastName = Console.ReadLine() ?? "";

                Console.WriteLine("Enter ID: ");
                int id = Int32.Parse(Console.ReadLine() ?? "");

                Console.WriteLine("Enter Photo URL: ");
                string photoUrl = Console.ReadLine() ?? "";

                Employee employee = new Employee(firstName, lastName, id, photoUrl);
                employees.Add(employee);
            }
            return employees;
        }

        // Entry point for application
        static void Main(string[] args)
        {
            List<Employee> employees = GetEmployees();
            Util.PrintEmployees(employees);
            Util.MakeCSV(employees);
        }
    }
}