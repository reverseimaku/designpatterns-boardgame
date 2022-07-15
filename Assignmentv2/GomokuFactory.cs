using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmentv2
{
    class GomokuFactory : GameFactory
    {
        protected override Game CreateGame()
        {
            Gomoku gomoku = new Gomoku();
            return gomoku;
        }
    }
}
