using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Thrower
{
    class Program
    {
        static void Main(string[] args)
        {
            ThrowDice("2d20");
            ThrowDice("3d10");

            Console.ReadKey();
        }

        public static void ThrowDice(string input)
        {
            List<string> diceList = input.Split('d').ToList();

            Random rng = new Random();

            for (int i = 0; i <= int.Parse(diceList[0]); i++)
            {
                Console.WriteLine(rng.Next(1, int.Parse(diceList[1]) + 1));
                
            }
            Console.WriteLine();
        }
    }
}
