using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate an object and give values to its attributes
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            employee.SayName();
            //Use polymorphism to create an object of type IQuittable and call the Quit() method on it
            IQuittable quittable = new Employee();
            quittable.Quit(employee);
            Console.ReadLine();
        }
    }
}