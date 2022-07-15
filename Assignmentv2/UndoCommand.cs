using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmentv2
{
    class UndoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Undo is not available in this version of the game. Much apologies.");
        }
    }

}
