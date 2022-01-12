using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        // Return list of employees inputted by user
        static List<string> GetEmployees()
        {
            List<string> employees = new List<string>();
            while (true)
            {
                Console.WriteLine("Please enter a name (leavy empty to exit):");
                string input = Console.ReadLine();
                if (input == "")
                {
                    break;
                }
                employees.Add(input);
            }
            return employees;
        }
        // Prints inputted employee list to CLI
        static void PrintEmployees(List<string> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine(employees[i]);
            }
        }
        // Entry point for application
        static void Main(string[] args)
        {
            List<string> employees = GetEmployees();
            PrintEmployees(employees);
        }
    }
}