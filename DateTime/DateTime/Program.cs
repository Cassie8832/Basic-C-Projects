using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //printing current datetime to console
            Console.WriteLine("The current date and time is:");
            Console.WriteLine(DateTime.Now);
            //asking user to input a number to be used as hours
            Console.WriteLine("Input a number of hours");
            //casting user input to double, so decimal numbers also work
            double userInput = Convert.ToDouble(Console.ReadLine());
            //declaring variable to be current time
            DateTime dateValueNow = DateTime.Now;
            //printing current time plus user input to show new date time hour
            Console.WriteLine($"Your number of hours added to the current time will be: {dateValueNow.AddHours(userInput)}");
            Console.ReadLine();
        }
    }
}