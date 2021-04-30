using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassSubmission
{
    class MathClass
    {
        public static void MathOp(int num1, int num2)
        {
            int total = num1 + 10;
            Console.WriteLine($"Your first number plus 10 is: {total}");
            Console.WriteLine($"Now you add: {num2}");

        }
    }
}