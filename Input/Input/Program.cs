using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            //asking user to input a number
            Console.WriteLine("Input a number");
            //bool flag for while loop 
            bool continueInput = true;
            //loop for more inputs if desired
            while (continueInput == true)
            {
                try //try catch block for user input data type. Must be able to cast to int
                {
                    //asking for user input
                    int userInput = Convert.ToInt32(Console.ReadLine());
                    //using streamwriter to log input to text file, and letting it append new inputs
                    using (StreamWriter file = new StreamWriter(@"C:\Users\Owner\Documents\GitHub\Basic-C-Projects\Iteration.txt", true))
                    {
                        file.WriteLine(userInput);
                    }
                    Console.WriteLine($"The input: \"{userInput}\", has been logged");
                    Console.WriteLine("More inputs? Please answer yes or no.");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "no")
                    {
                        //ends while loop condition
                        continueInput = false;
                    }
                }
                catch (FormatException)//format exception for data type
                {
                    continueInput = true;//continues while loop
                    Console.WriteLine("Please input a whole number");
                }
            }
            Console.WriteLine("Input Log:");
            //using streamreader to print all inputs to screen, inputs from previous console runs too.
            using (StreamReader file = new StreamReader(@"C:\Users\Owner\Documents\GitHub\Basic-C-Projects\Iteration.txt"))
            {
                Console.WriteLine(file.ReadToEnd());
            }
            Console.ReadLine();
        }
    }
}
