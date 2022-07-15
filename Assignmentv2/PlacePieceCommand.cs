using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmentv2
{
    class PlacePieceCommand : ICommand
    {
        // takes in the current game board, which player it is, the type of game, the boardpiece
        public PlacePieceCommand(char[,] gameBoard, Player player, Game game, Boardpiece bp)
        {
            Gameboard = gameBoard;
            Gameg = game;
            BP = bp;
            PY = player;
        }
        public char[,] Gameboard { get; }
        public Game Gameg { get; }
        public Boardpiece BP { get; }

        public Player PY { get; }

        public void Execute()
        {
            PY.Place(Gameg.GArray, BP);
        }
    }
}
