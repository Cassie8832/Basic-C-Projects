using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmission
{
    public class Person
    {
        //chaining two constructors together
        public Person(string fname) : this(fname, "Chamberlain")// gives last name when only first name is defined
        {
        }
        public Person(string fname, string lname)//constructor taking two strings, first and last names
        {
            FirstName = fname;
            LastName = lname;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}