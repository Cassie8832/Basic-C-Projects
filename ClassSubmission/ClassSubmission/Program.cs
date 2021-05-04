using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number");
            int num = Convert.ToInt32(Console.ReadLine());
            Divide.DivideBy2(num);

            Console.WriteLine("Input first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            //output parameter in method
            StaticTest.MethodTest(num1, num2, out int i);
            Console.WriteLine("Output of values added is: {0}", i);
            //overload method
            StaticTest.MethodTest(num1, num2);

            Console.ReadLine();
        }
    }
}