using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismSubmission
{
    public class Employee : Person, IQuittable
    {

        public override void SayName()
        {
            string fullName = firstName + " " + lastName;
            Console.WriteLine($"Name: [{fullName}]");
        }
        public void Quit(Employee employee)//Implement the Quit() method in any way you choose.
        {
            bool canQuit = true;//saying the employee can quit at anytime
            Console.WriteLine($"Can this person quit anytime: {canQuit}");
        }
    }
}
