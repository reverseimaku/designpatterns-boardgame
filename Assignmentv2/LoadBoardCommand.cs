using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmentv2
{
    class LoadBoardCommand : ICommand
    {
        public LoadBoardCommand(char[,] gameBoard)
        {
            Gameboard = gameBoard;
        }
        public char[,] Gameboard { get; }

        public void Execute()
        {
            GameAction.LoadGame(Gameboard);
        }
    }
}
