using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Validator
    {
        public static Roshambo GetUserChoice(string input)
        {
            Roshambo pick = Roshambo.rock;
            while (true)
            {
                if (input.ToLower() == "r")
                {
                    pick = Roshambo.rock;
                    break;
                }
                else if (input.ToLower() == "p")
                {
                    pick = Roshambo.paper;
                    break;
                }
                else if (input.ToLower() == "s")
                {
                    pick = Roshambo.scissors;
                    break;
                }
                else 
                {
                    Console.WriteLine("Invalid input");
                    input = Console.ReadLine();
                }
            }
            return pick;
        }
        public static int OpponentChoice()
        {
            int opp = 0;

            bool check = int.TryParse(Console.ReadLine(), out opp);
            while (check == false || opp > 2 || opp <1)
            {
                Console.WriteLine("invalid entry");
                continue;
            }
            
            return opp;
        }
    }
}
