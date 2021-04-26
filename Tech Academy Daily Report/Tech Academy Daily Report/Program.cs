using System;

namespace Tech_Academy_Daily_Report
{
    class Program
    {
        static void Main()
        {
            // First line stating The Tech Academy
            Console.WriteLine("The Tech Academy");
            // Second line stating this is a daily report
            Console.WriteLine("Student Daily Report");
            // Asking what your name is
            Console.WriteLine("What is your name?");
            // Assinging the string variable to "name"
            string studentName = Console.ReadLine();
            // Printing to the screen Hello and concatenating with the string "studentName"
            Console.WriteLine("Hello," + studentName + "!");
            // Asking what course you are on
            Console.WriteLine("What course are you on?");
            // Assigning the string variable to "courseName"
            string courseName = Console.ReadLine();
            // Printing to screen The course you are on is: and concatenating the string "courseName"
            Console.WriteLine("The course you are on is: " + courseName + ".");
            // Asking the page number
            Console.WriteLine("What page number?");
            //Assigning the integer variable to "pageNum" and converting input to integer
            int pageNum = Convert.ToInt32(Console.ReadLine());
            // Concatenating int "pageNum" with string
            Console.WriteLine("You are on step: " + pageNum);
            // asking for a boolean answer
            Console.WriteLine("Do you need help with anything?");
            Console.WriteLine("Please answer true or false");
            // assigning bool variable
            bool needHelp = Convert.ToBoolean(Console.ReadLine());
            if (needHelp == true) //providing if statement depending on answer true
            {
                Console.WriteLine("What do you need help with?");
                Console.ReadLine();
            }
            // asking for positive experiences
            Console.WriteLine("Were there any positive experiences you'd like to share?");
            Console.WriteLine("Please give specifics.");
            Console.ReadLine();
            // Asking for other feedback
            Console.WriteLine("Is there any other feedback you'd like to provide?");
            Console.WriteLine("Please be specific.");
            Console.ReadLine();
            //asking for hours studied and convert to int
            Console.WriteLine("How many hours did you study today?");
            int studyHours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fantastic job on getting " + studyHours + " hours in!");
            // adding finishing comments after all questions are asked
            Console.WriteLine("Thank You for your answers. An Instructor will respond to this shortly.");
            Console.WriteLine("Have a great day!!!");
            Console.ReadLine();
        }
    }
}
