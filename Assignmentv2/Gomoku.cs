using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Assignmentv2
{

    public class Gomoku : Game
    {
        char[,] g = new char[15, 15];
        Board gBoard = new Board();

        //GArray initialises the 15x15 board
        public char[,] GArray { get { return g; } }

        public void GameRules()
        {
            WriteLine("Gomoku is a game where players alternate turns placing a stone of their color in an empty intersection.");
            WriteLine("If the player places their pieces in 5 spaces diagonally, horizontally or vertically, the player wins the game.");
            WriteLine("Taken from Wikipedia.");
        }
        public void InitialiseGame(char[,] board)
        {
            WriteLine("Initialised game...");
            gBoard.StartBoard(board);
        }

        public void ContinueGame(char[,] board)
        {
            WriteLine("Continuing game...");
            gBoard.LoadBoard(board);
        }

        public void WinCondition(char[,] board)
        {

        }

    }
}
