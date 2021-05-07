using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsSubmission
{
    public class Employee : Person
    {


        public int Id { get; set; }
        // Overloading the == operator to compare Id of employees
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id)
            {
                Console.WriteLine("The ID's are equal");
                return true;//returns response if equal
            }
            else
            {
                Console.WriteLine("The ID's are not equal");
                return false;
            }
        }
        // Overloads != operator for comparing employee Id. Has to be included for == to work
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if (employee1.Id != employee2.Id)
            {
                Console.WriteLine("The ID's are not equal");
                return true;//returns response if not equal
            }
            else
            {
                Console.WriteLine("The ID's are equal");
                return false;
            }
        }



    }
}