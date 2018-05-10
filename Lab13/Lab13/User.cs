using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class User : Player
    {
        public User(string n) : base(n) { }
        public override void GetRoshambo()
        {
            Console.WriteLine("Please enter your choice Rock(r) Paper(p) Scissors(s)");
            UserChoice = Validator.GetUserChoice(Console.ReadLine());
        }
    }
}
