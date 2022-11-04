using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourCoinFlipApp
{
    public class UserInterface
    {
        public static void GameOver()
        {

            Console.WriteLine("Thank you for playing!");
            Environment.Exit(0);
        }

        public static int GetUserNumber()
        {
            int userNumber = 0;
            while (!int.TryParse(Console.ReadLine(), out userNumber))
            {
                Console.WriteLine("Incorrect input! \n Please select either 1 or 2!");
            }                                             
            return userNumber;
        }
        public static string UserGuess()
        {
            var userGuess = "";
            Console.WriteLine("Do you think your coin will land on heads or tails?");
            do
            {
                Console.WriteLine();
                Console.WriteLine("Enter 1 for heads!\nEnter 2 for tails!");
                Console.WriteLine();
                userGuess = Console.ReadLine();

            } while (userGuess != "1" && userGuess != "2");

            switch (userGuess)
            {
                case "1":
                    return "heads";
                default:
                    return "tails";
            }

        }

        public static void Comparison(string result, string userGuess)
        {
            if (userGuess == result)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Awesome! You guessed {userGuess}!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Sorry! You guessed {userGuess}!");
                Console.ResetColor();
            }
        }
    }
}

