using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CatWorx.BadgeMaker
{
    class Program
    {
        // Entry point for application
        async static Task Main(string[] args)
        {
            Console.WriteLine("Do you want to get data from an employee API (yes or no)?");
            bool getFromAPI = Console.ReadLine().ToLower() == "yes" ? true : false;

            List<Employee> employees = new List<Employee>();
            if (getFromAPI)
            {
                employees = await PeopleFetcher.GetFromAPI();
            } else 
            {
                employees = PeopleFetcher.GetEmployees();
            }

            Util.PrintEmployees(employees);
            Util.MakeCSV(employees);
            await Util.MakeBadges(employees);
        }
    }
}