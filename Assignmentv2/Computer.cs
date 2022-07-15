using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Assignmentv2
{
    class Computer : Player
    {
        public override void Place(char[,] gameboard, Boardpiece bp)
        {

            Board board = new Board();
            Random rdm = new Random();
            int firstChoice = rdm.Next(gameboard.GetLength(0));
            int secondChoice = rdm.Next(gameboard.GetLength(1));


            while (true)
            {

                if (board.CheckEmpty(gameboard, firstChoice, secondChoice) == true)
                {
                    Clear();
                    gameboard[firstChoice, secondChoice] = bp.BPiece();
                    board.UpdateBoard(gameboard);

                    break;
                }
            }
        }
    }
}
