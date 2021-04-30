using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMathClass MathObject = new MyMathClass();
            Console.WriteLine("Input a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input a second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MathObject.Area(num1, num2));
            //

            Console.WriteLine("Input a number");
            int numPlus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MyMathClass.Plus(numPlus));
            //

            Console.WriteLine("Input a number");
            int numMinus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(MyMathClass.Minus(numMinus));
            Console.ReadLine();


        }
    }
}