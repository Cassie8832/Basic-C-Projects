using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmission
{
    class MathOperation
    {
        public int MathOp(int num1, int num2 = 0)
        {
            int total = num1 + num2 + 10;
            Console.WriteLine("Your number/numbers added together then added to ten are:");
            return total;
        }
    }
}