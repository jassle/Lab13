using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            bool end = true;
            while (end)
            {
                List<Player> Player = new List<Player>();
                Console.WriteLine("Welcome to Ultimate Roshambo!!");
                Console.WriteLine("Please enter your name: ");
                Player.Add(new User(Console.ReadLine()));
                Player.Add(new Opponent1("Kamel"));

                Console.WriteLine($"Welcome {Player[0].UserName}, choose your opponent: Micky(1) or Johnny(2)");
                int opp = Validator.OpponentChoice();
                int usercount = 0;
                int oppcount = 0;
                int tiecount = 0;
                bool repeat = true;
                while (repeat)
                {
                    
                    Player[0].GetRoshambo();
                    Player[opp].GetRoshambo();

                    string[,] results = { { "Tie!", $"{Player[0].UserName} Wins!", $"{Player[1].UserName} Wins!" }, { $"{Player[1].UserName} Wins!", "Tie!", $"{Player[0].UserName} Wins!" }, { $"{Player[0].UserName} Wins!", $"{Player[1].UserName} Wins!", "Tie!" } };
                    Console.WriteLine($"{Player[0].UserChoice} vs {Player[1].UserChoice}");
                    Console.WriteLine(results[(int)Player[0].UserChoice, (int)Player[1].UserChoice]);
                    if (results[(int)Player[0].UserChoice, (int)Player[1].UserChoice] == "Tie")
                    {
                        tiecount = tiecount + 1;
                    }
                    else if (results[(int)Player[0].UserChoice, (int)Player[1].UserChoice] == $"{Player[0].UserName} Wins!")
                    {
                        usercount = usercount + 1;
                    }
                    else oppcount = oppcount + 1;
                    Console.WriteLine($"Wins {usercount} Losses {oppcount} Ties {tiecount} ");
                repeat = Continue("Would you like to continue? (Y/N)");
                }
                end = Continue("Would you like to play a different user? (Y/N)");
            }
        }

        private static bool Continue(string prompt)
        {
            Console.WriteLine(prompt);
            string cont = Console.ReadLine().ToUpper();
            if (cont == "N")
            {
                return false;

            }
            else if (cont == "Y")
            {
                return true;

            }
            else
            {
                Console.WriteLine("Invalid input, try again");
                return Continue(prompt);
            }
        }
    }
}
