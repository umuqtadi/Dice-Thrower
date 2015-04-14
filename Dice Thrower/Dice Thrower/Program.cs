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
            throw(2d20);
        }

        public static void ThrowDice(string diceString)
        {
            string[] diceArray = diceString.Split('d');

            Random rng = new Random();

            for (int i = 0; i <= int.Parse(diceArray[0]); i++)
            {
                if (rng.Next(0, int.Parse(diceArray[1] + 1))
                {
                    
                }
            }
        }
    }
}
