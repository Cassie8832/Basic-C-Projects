using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsSubmission
{
    public class Person   //created class called Person
    {
        public string FirstName { get; set; } //gave property first name
        public string LastName { get; set; } //last name

        public void SayName() //sayname property
        {
            string fullName = FirstName + " " + LastName;
            Console.WriteLine($"Name: [{fullName}]");
        }
    }
}
