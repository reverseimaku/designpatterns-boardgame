using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmentv2
{   
    //Concrete factory to get human player
    class HumanFactory : PlayerFactory
    {
        // Method returns new human player
        protected override Player CreatePlayer()
        {
            Player player = new Human();
            return player;
        }
    }
}
