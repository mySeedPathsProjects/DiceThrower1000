using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceThrower1000
{
    class Program
    {   
        static void Main(string[] args)
        {
            ThrowDice("10d6");
            ThrowDice("3d20");
            ThrowDice("100d6");

            Console.ReadKey();
        }
        /// <summary>
        /// See the results of dice
        /// </summary>
        /// <param name="diceString"></param>
        static void ThrowDice(string diceString)
        {
            Random rng = new Random();

            string resultString = "";
            string[] inputArray = diceString.Split('d');

            int numberOfThrows = int.Parse(inputArray[0]);
            int numberOfSides = int.Parse(inputArray[1]);

            for (int i = 0; i < numberOfThrows; i++)
            {
                int rollResult = rng.Next(1, numberOfSides + 1);
                resultString += (rollResult.ToString() + " ");
            }
            Console.WriteLine("Throwing: " + diceString);
            Console.WriteLine("Results: " + resultString);
        }
    }
}
