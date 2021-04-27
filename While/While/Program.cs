using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you guess my favorite color?");
            bool favColor = false;

            do //do while loop added so the correct guess is still displayed properly
            {
                Console.WriteLine("Guess a color:");
                string color = Console.ReadLine();

                switch (color)//switch statement using the input color
                {

                    case "pink":
                        Console.WriteLine("You guessed pink. That is correct!!!");
                        favColor = true;//stating favColor is true and the answer is correct
                        break;
                    default://defaut for any answer not associated with a case
                        Console.WriteLine("You guessed " + color + ". Try again.");
                        break;
                }
            }
            while (!favColor);//loop to be performed when favColor is true
            {

                Console.WriteLine("What is my favorite number 1 through 10?");
                bool favNum = false;

                while (!favNum)//while loop for favorite number
                {

                    Console.WriteLine("Guess a number?");
                    int number = Convert.ToInt32(Console.ReadLine());

                    switch (number)
                    {
                        case 8:
                            Console.WriteLine("That is correct!");
                            favNum = true;
                            break;
                        default:
                            Console.WriteLine("Your guess of: " + number + " is not correct.");
                            break;
                    }
                }
            }

            Console.Read();
        }
    }
}
