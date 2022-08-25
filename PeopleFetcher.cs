using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace CatWorx.BadgeMaker
{
    class PeopleFetcher
    {
        // Return list of employees inputted by user
        public static List<Employee> GetEmployees()
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

        // Return list of random employees from API
        async public static Task<List<Employee>> GetFromAPI()
        {
            List<Employee> employees = new List<Employee>();

            using (HttpClient client = new HttpClient())
            {
                string response = await client.GetStringAsync("https://randomuser.me/api/?results=10&nat=us&inc=name,id,picture");
                JObject json = JObject.Parse(response);

                foreach (JToken person in json.SelectToken("results")!)
                {
                    Employee employee = new Employee
                    (
                        person.SelectToken("name.first")!.ToString(),
                        person.SelectToken("name.last")!.ToString(),
                        Int32.Parse(person.SelectToken("id.value")!.ToString().Replace("-", "")),
                        person.SelectToken("picture.large")!.ToString()
                    );
                    employees.Add(employee);
                }
            }

            return employees;
        }
    }
}