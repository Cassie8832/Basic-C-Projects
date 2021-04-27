using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //assigning string variables
            string name ="Cassie Peets";
            string quote = " is concatenating ";
            string endQuote = "three strings!";

            //converts string to uppercase
            name = name.ToUpper();

            //concatenating the 3 strings
            Console.WriteLine(name + quote + endQuote);

            //Create a stringbuilder for paragraph with new line \n
            StringBuilder sb = new StringBuilder("This is StringBuilder.\n");

            //append a new sentence to end of first line but on new line \n
            sb.Append("Adding one sentence to the paragraph.\n");

            //append sb with new line sentence
            sb.Append("One line at a time.");

            Console.WriteLine(sb);//display stringbuilder and its strings
            Console.ReadLine();

        }
    }
}
