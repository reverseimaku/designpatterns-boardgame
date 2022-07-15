using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmentv2
{

    //Concrete factory to get computer player
    class ComputerFactory : PlayerFactory
    {

        // Method returns new computer player
        protected override Player CreatePlayer()
        {
            Player player = new Computer();
            return player;
        }
    }

}
