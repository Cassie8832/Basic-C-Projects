using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Assignment
{
    class Program
    {
        static void Main()
        {
        

            //====== PART ONE =======

            //// 1. Create a one-dimensional array of strings.
            //string[] greeting = { "Hello, ", "Today is a new day, ", "New opportunities await you, ", "Make the most of it, " };
            //// 2. Ask the user to input some text.
            //Console.WriteLine("Please add your name.");
            //string userInput = Console.ReadLine();
            //Console.WriteLine();//line break
            //                    // 3. A loop that iterates through each string in the array and adds the user's
            //                    // text input to the end of each string. This step will not output anything to the
            //                    // console, but will update each array element by appending the user's text.
            //for (int i = 0; i < greeting.Length; i++)
            //{
            //    greeting[i] = greeting[i] + userInput + "!";
            //}
            //// 4. Then create a loop that prints off each string in the array on a separate line.
            //for (int i = 0; i < greeting.Length; i++)
            //{
            //    Console.WriteLine(greeting[i]);
            //}

            ////========= PART TWO =========

            //// 1. An infinite loop.
            //// 2. Fix the infinite loop so that                                                  
            ////    it will execute properly.

            //Console.WriteLine("Guess any number 1 to 100");
            //int numberToGuess = 50;
            //int guessedNumber = Convert.ToInt32(Console.ReadLine());
            //bool isGuessed = guessedNumber == numberToGuess;

            //do
            //{
            //    if (isGuessed)
            //    {
            //        Console.WriteLine("You guessed correctly!");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"You guessed {guessedNumber}, please try again.");
            //    }
            //    Console.WriteLine("Please guess another number");
            //    guessedNumber = Convert.ToInt32(Console.ReadLine());
            //    isGuessed = guessedNumber == numberToGuess;
            //}
            //while (!isGuessed);
            //Console.WriteLine("You guessed the correct number!");

            //Console.Read();

            ////========== PART THREE =========
            //// 1. A loop where the comparison that’s used to determine whether
            //// to continue iterating the loop is a “<” operator.
            //for (int i = 0; i < 1; i++)
            //{
            //    Console.WriteLine(greeting[i]);
            //}
            //// 2. A loop where the comparison that’s used to determine whether
            //// to continue iterating the loop is a “<=” operator.
            //for (int i = 0; i <= 2; i++)
            //{
            //    Console.WriteLine(greeting[i]);
            //}

            //Console.WriteLine();//line break



            //======== PART FOUR =========

            // 1. A list of strings where each item in the list is unique.
            List<string> listColors = new List<string>() { "red", "pink", "purple" };
            // 2. Ask the user to input text to search for in the list
            Console.WriteLine("Input a primary color to find index.");
            string colorInput = Console.ReadLine();
            // 3. A loop that iterates through the list and then displays the index of the
            // list that contains matching text on the screen.
            foreach (string color in listColors)
            {
                int c = listColors.IndexOf(color);
                if (listColors[c] == colorInput)
                {
                    Console.WriteLine("Value of index: " + c);
                    break;// 5. Add code to the loop that stops it from executing once a
                          // match has been found.

                }
                if (color != colorInput)
                {
                    c++;
                }
                if (c >= listColors.Count)
                {
                    // 4. Add code to the loop to check if the user put in text that isn't on
                    // the list and, if they did, tells the user their input is not on the list.
                    Console.WriteLine("No index found.");
                }
            }

            Console.WriteLine();//linebreak

            //============= PART FIVE =============

            // 1.A list of strings that has at least two identical strings in the list.
            // Ask the user to select text to search for in the list.
            List<string> listFlower = new List<string>() { "sunflower", "daisy", "rose", "tulip",
                        "hydrangea", "daisy" };

            Console.WriteLine("Name a type of flower to find its index, or indices.");
            string inputFlower = Console.ReadLine();

            // 2.Create a loop that iterates through the loop and then displays the indices
            // of the array that contain matching text on the screen.
            bool exists = false;
            for (int i = 0; i < listFlower.Count; i++)
            {
                if (listFlower[i] == inputFlower)
                {
                    Console.WriteLine(i);
                    exists = true;
                }
                // 3.Add code to the loop to check if the user put in text that isn't on the list and,
                // if they did, tells the user their input is not on the list.
                if (exists == false && i == listFlower.Count - 1)
                {
                    Console.WriteLine("Does not exist in list.");
                }
            }
            Console.WriteLine();//linebreak

            // ============= PART SIX ================
            // 1.Create a list of strings that has at least two identical strings in the list.
            List<string> petsList = new List<string>() { "cat", "dog", "cat", "snake", "hedgehog",
                "dog" };
            List<int> petCount = new List<int>() { 1 };//new list to add int for counter

            Console.WriteLine("Type in a pet type to find if it is on list.");
            string userPet = Console.ReadLine();//asking user to input text to find occurences of pet type
            // 2.Create a foreach loop that evaluates each item in the list.
            foreach (string pet in petsList)
            {
                int p = 1;
                if (pet == userPet)
                {
                    petCount.Add(p);// adds int to list to be used as counter
                }

            }
            // 3. Displays a message
            //    showing the string and whether or not it has already appeared in the list.
            foreach (int p in petCount)
            {
                int count = petCount.Count - 1;// list count to be used as counter
                if (count >= 1)// is on list
                {
                    Console.WriteLine("The type: " + userPet + " occurs " + count + " times.");
                    break;
                }
                if (count == 0)// not on list
                {
                    Console.WriteLine(userPet + " occurs " + count + " times.");
                }
            }
            Console.ReadLine();
        }
    }
}

