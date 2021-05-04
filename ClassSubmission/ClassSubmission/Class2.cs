using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    static class StaticTest
    {
        public static void MethodTest(int num1, int num2, out int i)
        {

            int total = num1 + num2;
            i = total;

        }
        public static void MethodTest(int num1, int num2)
        {
            int n = num1 * num2;
            Console.WriteLine($"Output of values multiplied is: {n}");

        }
    }
}