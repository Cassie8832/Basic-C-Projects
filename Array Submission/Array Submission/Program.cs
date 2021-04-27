using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray1 = { 1, 2, 3, 4, 5 };
            string[] stringArray1 = { "A", "B", "C", "D", "E" };

            Console.WriteLine("Select an index of the numArray to display the integer.");
            int inputNum = Convert.ToInt32(Console.ReadLine());
            int i = numArray1.Length;
            if (inputNum < i)
            {
                Console.WriteLine("Value is: " + numArray1[inputNum]);
            }
            else if (inputNum >= i)
            {
                Console.WriteLine("That index does not exist.");
            }
            Console.WriteLine();//line break
            Console.WriteLine("Select an index of the stringArray to display the string.");
            int inputString = Convert.ToInt32(Console.ReadLine());
            int n = stringArray1.Length;
            if (inputString < n)
            {
                Console.WriteLine("Value is: " + stringArray1[inputString]);
            }
            else if (inputString >= n)
            {
                Console.WriteLine("That index does not exist.");
            }
            Console.WriteLine();//line break
            List<string> stringList = new List<string>();
            stringList.Add("X");
            stringList.Add("Y");
            stringList.Add("Z");
            stringList.Add("Cassie");

            Console.WriteLine("Select and index of the list: stringList.");
            int inputList = Convert.ToInt32(Console.ReadLine());
            if (inputList <= 3)
            {
                Console.WriteLine("Value is: " + stringList[inputList]);
            }
            else
            {
                Console.WriteLine("Does not exist.");
            }
            Console.ReadLine();

        }
    }
}
