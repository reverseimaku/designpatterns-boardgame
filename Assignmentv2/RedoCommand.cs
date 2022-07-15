using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmentv2
{
    class RedoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Redo is not available in this version of the game. Much apologies.");
        }
    }
}
