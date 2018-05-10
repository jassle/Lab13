using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Opponent1 : Player
    {
        public override void GetRoshambo()
        {
            Random r = new Random();
            UserChoice = (Roshambo)r.Next(3);
        }
        public Opponent1(string n) : base(n) { }
    }
}
