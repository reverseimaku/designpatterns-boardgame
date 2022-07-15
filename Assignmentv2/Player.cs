using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Assignmentv2
{
    public class Player
    {
        string name;

        public virtual string Name
        {
            get { return name; }
            set { name = value; }
        }
        public virtual void Place(char[,] gameboard, Boardpiece bp)
        {
        }
    }

}
