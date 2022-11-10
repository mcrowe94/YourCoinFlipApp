// See https://aka.ms/new-console-template for more information

using YourCoinFlipApp;



int userInput;

do
{

    Console.WriteLine("Welcome to your Coin Flip App!");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("------------------------------");
    Console.ResetColor();

    string userGuess = UserInterface.UserGuess();
    Console.WriteLine($"You are guessing {userGuess}!");
    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Press ENTER to flip the coin!");
    Console.ReadLine();
    Console.ResetColor();

    string result = GameManager.FlipAction(); //returning string from method & naming it result
    ConsoleLogging.CoinFlipGraphic(); //method called from the ConsoleLogging Class

    Console.WriteLine(result);
    UserInterface.Comparison(result, userGuess);

    Console.WriteLine("Would you like to play again? Please press 1 to say 'Yes' or press 2 for 'No'.");
    userInput = UserInterface.GetUserNumber();
    if(userInput != 1 || userInput != 2)
    {
        Console.WriteLine("Incorrect input! \n Please select either 1 or 2!");
        userInput = UserInterface.GetUserNumber();
    }
    
    //This while loop below would allow the user to input any number for the end of the game - game would not restart or end
    //The new if statement above now only allows the user to input 1 or 2 to restart the game or end the game

    //while (userInput != 1 || userInput != 2)
    //{
    //    Console.WriteLine("Incorrect input! \n Try again!");
    //    userInput = UserInterface.GetUserNumber();
    //}

} while (userInput != 2);

UserInterface.GameOver();

//test comment 11/10/22

switch (userInput)
{
    case 1:
        UserInterface.UserGuess();
        break;
    case 2:
        UserInterface.GameOver();
        break;
    default:
        Console.WriteLine("Incorrect input! \n Try again!");
        UserInterface.GetUserNumber();
        break;

}







