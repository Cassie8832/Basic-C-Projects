using System;

namespace Package_Express_Quote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express.");
            Console.WriteLine("Please follow the instructions below:");
            Console.WriteLine();//linebreak
            Console.WriteLine("What is your package weight?");
            int weight = Convert.ToInt32(Console.ReadLine());//converting user input to int and assigning it to variable
            if (weight > 50)//if statement to see if user input meets condition
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");//ends program
            }
            else if (weight <= 50)//else if to continue running program
            {
                Console.WriteLine("What is the package width?");
                int width = Convert.ToInt32(Console.ReadLine());//converting user input to int and assigning it to variable
                Console.WriteLine("What is the package height?");
                int height = Convert.ToInt32(Console.ReadLine());//converting user input to int and assigning it to variable
                Console.WriteLine("What is the package length?");
                int length = Convert.ToInt32(Console.ReadLine());//converting user input to int and assigning it to variable
                int dimension = height + width + length;//assigning int variable to find next condition to continue program
                if (dimension > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");//ends program
                }
                else if (dimension <= 50)
                {
                    int dimNum = height * width * length * weight;//defining variable to use math for finding quote
                    int quote = dimNum / 100;//quote using variables from previous math steps
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote + ".00");//printing variable quote as doolar amount
                }
            }
            else
            {
                Console.WriteLine("OOPPPS..Please follow the instructions and try again.");//if this is used there is a problem
            }
            Console.ReadLine();

        }
    }
}
