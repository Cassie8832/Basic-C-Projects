using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmission
{
    class MyMathClass
    {
        public int MainMath(int num1)
        {
            int num2 = 5;
            Console.WriteLine("Your number multiplied by five is:");
            return num1 * num2;
        }
        public double MainMath(double numPlus)
        {
            double num2 = 10.5;
            Console.WriteLine("Your number plus 10.5 as an integer is:");
            int num1ToInt = Convert.ToInt32(numPlus);
            int num2ToInt = Convert.ToInt32(num2);
            return num1ToInt + num2ToInt;
        }
        public int MainMath(string numMinus)
        {
            int numConvert = Convert.ToInt32(numMinus);
            int num2 = 25;
            Console.WriteLine("Your number subtracted from twenty five is:");
            return num2 - numConvert;
        }
    }
}
