using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    abstract class Player
    {
        public string UserName { set; get; }
        
        public Roshambo UserChoice { set; get; }

        public Player(string n)
        {
            UserName = n;
        }
        public abstract void GetRoshambo();

    }
}
