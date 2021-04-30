using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            MathClass mathClass = new MathClass();


            MathClass.MathOp(num1: 20, num2: 40);

            Console.WriteLine();

            MathClass.MathOp(40, 50);

            Console.ReadLine();
        }
    }
}
