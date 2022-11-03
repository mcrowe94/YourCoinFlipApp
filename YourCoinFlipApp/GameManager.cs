using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourCoinFlipApp
{
    public class GameManager
    {
        public static string FlipAction()
        {

            var answer = "";
            Random rng = new Random();
            int randomNumber = rng.Next(1, 101);
            //get a random number between 1 and 101 ^

            //if the random number is divisible(%) by 2 the coin is heads otherwise it is tails
            if (randomNumber % 2 == 0)
            {
                answer = "heads";
                return answer;
            }
            else
            {
                answer = "tails";
                return answer;
            }

        }
    }
}     
    

