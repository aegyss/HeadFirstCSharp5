using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharp5_3
{
    static class HiLoGame
    {
        public const int MAXIMUM = 10;
        public static Random random = new Random();
        public static int CurrentNumber { get; set; } = random.Next(1, MAXIMUM + 1);
        public static int Pot { get; set; } = 10;

        public static void Guess(bool higher)
        {
            int nextNumber = random.Next(1, MAXIMUM + 1);
            if ((higher && nextNumber >= CurrentNumber) || (!higher && nextNumber <= CurrentNumber))
            {
                Console.WriteLine($"The next number is {nextNumber}. You guessed correctly. ");
                Pot++;
            }
            else
            {
                Console.WriteLine($"The next number is {nextNumber}. You guessed wrong.");
                Pot--;
            }
            CurrentNumber = nextNumber;
        }


            


    }
}
