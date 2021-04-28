using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Cassie";
            //string quote = "The man said, \"Hello, Cassie.\"\nHello on a new line.\n\tHello on a new tab.";
            //string fileName = @"C:\Users\Cassie;	
            

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("e");

            //int length = name.Length;

            //name = name.ToUpper();

            //Console.WriteLine(length);
            //Console.WriteLine(quote);
            //Console.WriteLine(trueOrFalse);
            //Console.WriteLine(name);
            //Console.ReadLine();



            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Cassie");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
