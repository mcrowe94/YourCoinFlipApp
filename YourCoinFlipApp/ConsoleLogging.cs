using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourCoinFlipApp
{
    public class ConsoleLogging
    {
        public static void CoinFlipGraphic() //this is void because nothing RETURNS from this method
        {                                    //just a loading graphic for the coin flip proccess
            for (int i = 0; i < 20; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("|");
                Thread.Sleep(75);
                Console.Write("\b\b\b");
                Console.Write("/");
                Thread.Sleep(75);
                Console.Write("\b\b\b");
                Console.Write("-");
                Thread.Sleep(75);
                Console.Write("\b\b\b");
                Console.Write("\\");
                Thread.Sleep(75);
                Console.Write("\b\b\b");
            }

            Console.WriteLine("__");
            Console.WriteLine();
            Console.ResetColor();

        }

    }

}

