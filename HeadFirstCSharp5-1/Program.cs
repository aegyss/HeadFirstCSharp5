using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharp5
{
    class Program
    {
        static void Main(string[] args)
        {
            SwordDamage swordDamage = new SwordDamage();
            Random RNG = new Random();
            while (true)
            {
                Console.Write("0 for standard physical damage. 1 for magic damage. 2 for flaming damage. 3 for both, anything else to quit.");
                char keyPressed = Console.ReadKey().KeyChar;
                if (keyPressed != '0' && keyPressed != '1' && keyPressed != '2' && keyPressed != '3')
                    return;
                int roll = RNG.Next(1, 7) + RNG.Next(1, 7) + RNG.Next(1, 7);
                swordDamage.Roll = roll;
                swordDamage.SetMagic(keyPressed == '1' || keyPressed == '3');
                swordDamage.SetFlaming(keyPressed == '2' || keyPressed == '3');
                Console.WriteLine($"\nYou rolled {roll} for {swordDamage.Damage} damage.\n");


            }


        }
    }
}
