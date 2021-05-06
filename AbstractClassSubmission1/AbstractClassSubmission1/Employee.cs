using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassSubmission
{   //3.Create another class called Employee and have it inherit from the Person class
    //Have your Employee class from the previous drill inherit that interface 
    public class Employee : Person, Work
    {
        //4.Implement the SayName() method inside of the Employee class.
        public override void SayName()
        {
            string fullName = firstName + " " + lastName;
            Console.WriteLine($"Name: [{fullName}]");
        }
        public void Work(Employee employee)//Implement the Work() method in any way you choose.
        {
            bool canWork = true;
            Console.WriteLine($"Can this person work anytime: {canWork}");
        }

    }
}