using System;
using System.Collections.Generic;
using static System.Console;
using System.Collections;

namespace Assignmentv2
{
    class SaveBoardCommand : ICommand
    {
        public SaveBoardCommand(char[,]gameBoard)
        {
            Gameboard = gameBoard;
        }
        public char[,] Gameboard { get; }

        public void Execute()
        {
            GameAction.SaveGame(Gameboard);
        }
    }

}
