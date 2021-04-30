using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMathClass mathObject1 = new MyMathClass();
            Console.WriteLine("Input a whole number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(mathObject1.MainMath(num1));
            //
            MyMathClass mathObject2 = new MyMathClass();
            Console.WriteLine("input a decimal number:");
            double numPlus = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(mathObject2.MainMath(numPlus));
            //
            MyMathClass mathObject3 = new MyMathClass();
            Console.WriteLine("Input a whole number:");
            string numMinus = Console.ReadLine();
            Console.WriteLine(mathObject3.MainMath(numMinus));
            //
            Console.ReadLine();
        }
    }
}