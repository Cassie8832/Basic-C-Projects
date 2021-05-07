using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSubmission
{
    public class Employee
    {
        //properties to create employees
        public int empId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        //method for listing full name
        public string SayName()
        {
            string fullName = firstName + " " + lastName;
            return fullName;
        }
    }
}