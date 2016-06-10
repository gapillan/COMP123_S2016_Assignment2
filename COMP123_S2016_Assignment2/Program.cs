using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Author's Name: Golden Pamela Apillanes
 * Author's Student Number: 300867201
 * Date Modified: June 10nd 2016 
 * Program Description: Implementing the SuperHero class associated with the Hero Class
 * Revision History: June 10nd 2016 
 */
namespace COMP123_S2016_Assignment2
{
    /**
     * This class is the driver class for our Program
     * 
     * @class Program
     */
    class Program
    {
         /**
         * The main method for our driver class Program
         *
         * @method Main
         * @param {string[]} args
         */
        static void Main(string[] args)
        {
            SuperHero masterRoshi = new SuperHero("Master Roshi");

            string playersResponse = "";

            do
            {
                masterRoshi.Fight();
                masterRoshi.Show();
                Console.WriteLine();
                Console.WriteLine("Better luck next time.");
                Console.WriteLine("Would you like to play again?");
                Console.WriteLine("YES/NO");
                playersResponse = Console.ReadLine();
            }
            while (playersResponse == "yes");
            Console.WriteLine();
        }
    }
}
