using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmentv2
{


    // Creating a player factory as an abstract
    public abstract class PlayerFactory
    {
        protected abstract Player CreatePlayer();

        //GetPlayer is the method called when generating from the Concrete factories
        public Player GetPlayer()
        {
            // This method returns the concrete factory's CreatePlayer method
            return this.CreatePlayer();
        }
    }

}
