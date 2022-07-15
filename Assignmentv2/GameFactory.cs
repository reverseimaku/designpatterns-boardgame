using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmentv2
{
    public abstract class GameFactory
    {
        protected abstract Game CreateGame();

        public Game MakeGame()
        {
            return this.CreateGame();
        }
    }


}
