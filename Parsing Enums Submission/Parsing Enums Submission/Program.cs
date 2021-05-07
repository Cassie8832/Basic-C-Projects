using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // User is asked to input day of week
            Console.WriteLine("Input the current day of the week:");
            bool isDay = false;// used as flag for while loop
            while (isDay == false)
            {
                try //try block to see if input matches enum
                {
                    //input
                    string userDay = Console.ReadLine();
                    //Parsing user input with enum list which is not case sensitive
                    DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userDay, true);
                    //checking if string or int value entered is in enum
                    if (Enum.IsDefined(typeof(DaysOfTheWeek), day))
                    {
                        Console.WriteLine($"The day of the week is {day}!");
                        isDay = true; //satisfies while loop
                    }
                    else
                    {
                        Console.WriteLine("Please enter an actual day of the week");
                        isDay = false;//repeats while loop
                    }


                }
                catch (Exception)//generic exception thrown when input is wrong
                {
                    Console.WriteLine("Please enter an actual day of the week");
                    isDay = false;
                }
            }
            Console.ReadLine();

        }
    }
    //enum for days of the week
    public enum DaysOfTheWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
}