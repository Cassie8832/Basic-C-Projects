using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create constant variable
            const string myName = "My name is:";
            //using var keyword, created variable from Person
            var newPerson1 = new Person("Cassie");
            Person newPerson2 = new Person("Josh", "Peets");
            //print const and var
            Console.WriteLine($"{myName} {newPerson1.FirstName} {newPerson1.LastName}");
            Console.WriteLine($"{myName} {newPerson2.FirstName} {newPerson2.LastName}");
            Console.ReadLine();
        }
    }
}