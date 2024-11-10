
//Create a method IncreaseScore that takes a ref integer parameter representing a 
//player’s score and increases it by 10.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Part5Assignment
{
    public class Game
    {
        // Method to increase the player's score
        public void IncreaseScore(ref int score)
        {
            score += 10;
            Console.WriteLine($"Score increased by 10. New Score: {score}");
        }
    }
}