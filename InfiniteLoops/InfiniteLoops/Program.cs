using System;

namespace InfiniteLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess any number 1 to 100");
            int numberToGuess = 50;
            int guessedNumber = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = guessedNumber == numberToGuess;

            do
            {
                if (isGuessed)
                {
                    Console.WriteLine("You guessed correctly!");
                }
                else
                {
                    Console.WriteLine($"You guessed {guessedNumber}, please try again.");
                }
                Console.WriteLine("Please guess another number");
                guessedNumber = Convert.ToInt32(Console.ReadLine());
                isGuessed = guessedNumber == numberToGuess;
            }
            while (!isGuessed);
            Console.WriteLine("You guessed the correct number!");

            Console.Read();
        }
    }
}
