using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //list of 10 employees, instantiated from class employee
            List<Employee> employees = new List<Employee>()
            {
                new Employee { empId = 1, firstName = "Joe", lastName = "Anderson" },
                new Employee { empId = 2, firstName = "Joe", lastName = "Birch" },
                new Employee { empId = 3, firstName = "Cassie", lastName = "Peets" },
                new Employee { empId = 4, firstName = "Arya", lastName = "Meadow" },
                new Employee { empId = 5, firstName = "Aiden", lastName = "Maximus" },
                new Employee { empId = 6, firstName = "Josh", lastName = "Jones" },
                new Employee { empId = 7, firstName = "Cheryl", lastName = "Trescot" },
                new Employee { empId = 8, firstName = "Larry", lastName = "Bass" },
                new Employee { empId = 9, firstName = "Megan", lastName = "Brown" },
                new Employee { empId = 10, firstName = "Liz", lastName = "Smith" }
            };
            //foreach loop adding to new list if first name is joe
            foreach (Employee employee in employees)
            {
                if (employee.firstName == "Joe")
                {
                    List<string> listSameName = new List<string>();
                    listSameName.Add(employee.firstName + employee.lastName);
                    Console.WriteLine($"{employee.firstName} {employee.lastName}");
                }
            }
            //lambda to the above foreach loop
            List<Employee> listJoe = employees.Where(x => x.firstName == "Joe").ToList();
            //printing to the console the names of employees named joe
            Console.WriteLine($"{listJoe.Count} employees have the same first name!");
            Console.WriteLine($"{listJoe[0].SayName()} and {listJoe[1].SayName()}!");

            //lambda for new list if empId is greater than 5
            List<Employee> listId = employees.Where(x => x.empId > 5).ToList();
            //foreach loop to print list names to console from lambda expression new list
            Console.WriteLine("These employees have an ID greater than 5:");
            foreach (Employee employee in listId)
            {
                //prints each employee name and ID
                Console.WriteLine($"{employee.SayName()} ID:{employee.empId}");
            }
            Console.ReadLine();
        }
    }
}