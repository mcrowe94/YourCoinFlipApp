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

    } while (userInput != 2);

    UserInterface.GameOver();



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




    


