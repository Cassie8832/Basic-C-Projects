using System;

namespace Insurance_Approval
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Car Insurance Approval");
            Console.WriteLine();//line break
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());//casting user input to int
            Console.WriteLine("Have you ever had a DUI?");
            Console.WriteLine("Please answer true or false.");//asking to provide either true or false input
            string DUI = Console.ReadLine();//assigning user input to string variable
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());//casting user input to int variable
            bool approved = age > 15 && DUI == "false" && tickets <= 3;//using boolean to answer true if age is > 15, DUI equals false, and tickets < or equal to 3
            Console.WriteLine();//line break
            Console.WriteLine("Qualified?");
            Console.WriteLine(approved);//using bool variable to print true or false depending if conditions met in bool variable "approved"
            Console.ReadLine();
        }
    }
}
