using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Assignmentv2
{

    class Human : Player
    {
        string name;

        public override string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override void Place(char[,] gameboard, Boardpiece bp)
        {

            Board board = new Board();


            int firstChoice, secondChoice;


            while (true)
            {
                //update board
                Write("Enter row >");
                string firstmove = ReadLine();

                //check if firstmove is integer. outputs firstChoice
                bool checkChoiceNum = int.TryParse(firstmove, out firstChoice);

                if (firstChoice >= gameboard.GetLength(0) || firstChoice < 0 || checkChoiceNum == false)
                {
                    WriteLine("Invalid field. Please try again.");
                }
                else
                {
                    Write("Enter column >");
                    string secondmove = ReadLine();

                    bool checkChoiceNum2 = int.TryParse(secondmove, out secondChoice);

                    if (secondChoice >= gameboard.GetLength(1) || secondChoice < 0 || checkChoiceNum2 == false)
                    {
                        WriteLine("Invalid field. Please try again from the start.");
                    }
                    else if (board.CheckEmpty(gameboard, firstChoice, secondChoice) == false)
                    {
                        WriteLine("Space is already occupied. Please try again.");
                    }
                    else
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
}
