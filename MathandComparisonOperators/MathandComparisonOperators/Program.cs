using System;

namespace MathandComparisonOperators
{
    class Program
    {
        static void Main()
        {
            // Multiplying an input number by 50
            Console.WriteLine("Please input a number:");
            // casting input to int 
            int multiplyByFifty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number multiplied by 50 is: " + multiplyByFifty * 50);

            // Dividing input by 12.5
            Console.WriteLine("Please input another number:");
            //casting to double data type to include decimals
            double divideByTwelveFive = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your number divided by 12.5 is: " + divideByTwelveFive / 12.5);

            // Adding 25 to an input
            Console.WriteLine("Please input another number:");
            //assigning variables and casting to int
            int addTwentyFive = Convert.ToInt32(Console.ReadLine());
            // assigning variable of total to add 25
            int total = addTwentyFive + 25;
            //casting int total to string
            Console.WriteLine("Your number added to 25 is: " + total.ToString());

            // Using boolean logic to determine if input is greater than 50
            Console.WriteLine("Please input another number:");
            // assigning and casting variable to int
            int n = Convert.ToInt32(Console.ReadLine());
            int X = 50;
            //assigning boolean variable with input variable
            bool isGreater = n > X;
            Console.WriteLine("Is your number greater than 50? " + isGreater);

            // Finding the remainder of input divided by 7 using modulus
            Console.WriteLine("Please input another number:");
            //casting variable to int
            int numModulus = Convert.ToInt32(Console.ReadLine());
            // using modulus to find the remainder
            Console.WriteLine("The remainder of your number divided by 7 is: " + numModulus % 7);
            Console.ReadLine();
        }
    }
}
