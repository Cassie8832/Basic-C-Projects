using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); //instantiate employee object
            employee.FirstName = "Sample"; //initialize employee object with first name sample
            employee.LastName = "Student"; //initailize employee object with last name student
            employee.SayName(); //sayname superclass method
            Console.ReadLine();
        }
    }
}