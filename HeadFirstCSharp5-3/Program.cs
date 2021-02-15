using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharp5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //HiLoGame.random = new Random(1);
            //Random cheat = new Random(1);

            Console.WriteLine("Welcome to HiLo.");
            Console.WriteLine($"Guess if the next number will be higher or lower than the current number, up to a maximum of {HiLoGame.MAXIMUM}");   
            while (HiLoGame.Pot > 0)
            {
                //Console.WriteLine($"CHEATS ENABLED: The next number will be {cheat.Next(1, HiLoGame.MAXIMUM + 1)}");
                Console.WriteLine($"The current number is {HiLoGame.CurrentNumber}");
                Console.WriteLine("Press '2' to guess higher. Press '1' to guess lower.");
                Console.WriteLine($"Press any other key to quit with ${HiLoGame.Pot}.");
                char key = Console.ReadKey(true).KeyChar;
                if (key == '2')
                    HiLoGame.Guess(true);
                else if (key == '1')
                    HiLoGame.Guess(false);
                else return;
            }
            Console.WriteLine("The pot is empty. You lose!");
        }
    }
}
