using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.IO;
using System.Linq;

namespace Assignmentv2
{
    public class Board
    {
        
        public bool CheckEmpty(char[,] gameboard, int xmove, int ymove)
        {

            if (gameboard[xmove, ymove] != ' ')
            {
                return false;
            }
            return true;



        }

        // counts the number of board pieces that occupy the space. If all spaces are occupied it's a draw
        public void CheckDraw(char[,] gameboard)
        {
            int countOccupied = 0;
            for (int i = 0; i < gameboard.GetLength(0); i++)
            {
                for (int j = 0; j < gameboard.GetLength(1); j++)
                {
                    if (gameboard[j, i] != ' ')
                    {
                        countOccupied++;
                    }
                }
            }

            if (countOccupied >= (gameboard.GetLength(0) * gameboard.GetLength(1)))
            {
                WriteLine("Draw");
            }
        }

        public void CheckWin(bool xwin, bool owin)
        {
            if (xwin == true)
            {
                Clear();
                WriteLine("X is the winner.");
            }
            if (owin == true)
            {
                Clear();
                WriteLine("O is the winner.");
            }

            
        }

        // Draws the board with the updated player moves each time
        //////note: put this in Gomoku class instead
        public void UpdateBoard(char[,] gameboard)
        {
            Game gomoku = new Gomoku();

            bool xwin = false;
            bool owin = false;
            WriteLine("X. | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |10 |11 |12 |13 |14 |");
            for (int y = 0; y < gameboard.GetLength(0); y++)
            {

                Console.Write("{0}. | ", y);

                for (int x = 0; x < gameboard.GetLength(1); x++)
                {

                    Console.Write(gameboard[y, x]);
                    Console.Write(" | ");


                    //win = CheckWin(gameboard, x, y);
                    //WriteLine(win);
                    
                    //Note: Has an error where if player enters [14,14] the game will stop, hence the if condition
                    if (y < 10 || x < 10 )
                    {

                        //WinCondition is supposed to be implemented as a seperate class but condition does not work hence it is an empty class, and the method is called here itself
                        gomoku.WinCondition(gameboard);
                        
                        if ((gameboard[y, x] == 'X' && gameboard[y, x + 1] == 'X' && gameboard[y, x + 2] == 'X' && gameboard[y, x + 3] == 'X' && gameboard[y, x + 4] == 'X') //if horizontal in a row
                            || (gameboard[y, x] == 'X' && gameboard[y + 1, x] == 'X' && gameboard[y + 2, x] == 'X' && gameboard[y + 3, x] == 'X' && gameboard[y + 4, x] == 'X') //if vertical in a row
                            || gameboard[y, x] == 'X' && gameboard[y + 1, x + 1] == 'X' && gameboard[y + 2, x + 2] == 'X' && gameboard[y + 3, x + 3] == 'X' && gameboard[y + 4, x + 4] == 'X') //if diagonal in a row

                        {
                            xwin = true;
                        }

                        if (y >= 4 && x >= 4 && gameboard[y, x] == 'X' && gameboard[y - 1, x - 1] == 'X' && gameboard[y - 2, x - 2] == 'X' && gameboard[y - 3, x - 3] == 'X' && gameboard[y - 4, x - 4] == 'X')
                        {
                            xwin = true;
                        }


                        if ((gameboard[y, x] == 'O' && gameboard[y, x + 1] == 'O' && gameboard[y, x + 2] == 'O' && gameboard[y, x + 3] == 'O' && gameboard[y, x + 4] == 'O') //if horizontal in a row
                            || (gameboard[y, x] == 'O' && gameboard[y + 1, x] == 'O' && gameboard[y + 2, x] == 'O' && gameboard[y + 3, x] == 'O' && gameboard[y + 4, x] == 'O') //if vertical in a row
                            || (y <= 14 && x <= 14 && gameboard[y, x] == 'O' && gameboard[y + 1, x + 1] == 'O' && gameboard[y + 2, x + 2] == 'O' && gameboard[y + 3, x + 3] == 'O' && gameboard[y + 4, x + 4] == 'O') //if diagonal in a row
                            )
                        {
                            owin = true;
                        }
                    }
                }
                Console.WriteLine();
            }
            CheckWin(xwin, owin);
            if (xwin == true || owin == true)
            {
                Menu menu = new Menu();
                WriteLine();
                WriteLine("Press any key to go back to the main menu.");
                ReadKey();
                menu.ViewMenu();
            }
        }

        public void StartBoard(char[,] gameboard)
        {
            WriteLine("X. | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |10 |11 |12 |13 |14 |");
            for (int y = 0; y < gameboard.GetLength(0); y++)
            {

                Write("{0}. | ", y);
                for (int x = 0; x < gameboard.GetLength(1); x++)
                {

                    gameboard[y, x] = ' ';
                    Console.Write(gameboard[y, x]);
                    Console.Write(" | ");

                }
                Console.WriteLine();
            }
        }

        // Loads the board according to current load positions
        public void LoadBoard(char[,] gameboard)
        {
            WriteLine("X. | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |10 |11 |12 |13 |14 |");
            for (int y = 0; y < gameboard.GetLength(0); y++)
            {

                Write("{0}. | ", y);
                for (int x = 0; x < gameboard.GetLength(1); x++)
                {
                    Console.Write(gameboard[y, x]);
                    Console.Write(" | ");

                }
                Console.WriteLine();
            }
        }

        // GamePrompts lets the player select an option before playing a move
        public void GamePrompts(ref char userInput, Menu menu, Game game, GameControl gameControl)
        {

            ICommand saveBoard = new SaveBoardCommand(game.GArray);
            ICommand undoBoard = new UndoCommand();
            ICommand redoBoard = new RedoCommand();


            WriteLine();

            while (true)
            {
                WriteLine("___________________________________________");
                WriteLine("z to play the next move");
                WriteLine("s to save board");
                WriteLine("x to view Rules");
                WriteLine("c to view Online Help");
                WriteLine("u to Undo move");
                WriteLine("r to Redo move");
                WriteLine("m to Go back to the Menu");
                WriteLine("q to Exit");
                WriteLine();
                Write("Select your option > ");
                userInput = Convert.ToChar(ReadLine());
                WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                if (userInput == 'z' || userInput == 'm')
                {
                    break;
                }
                if (userInput == 's')
                {
                    gameControl.SetCommand(saveBoard);
                    gameControl.InvokeCommand();
                    WriteLine();
                    WriteLine("The board has been saved.");
                    WriteLine();
                    WriteLine();
                }
                else if (userInput == 'x')
                {
                    menu.ViewRules();
                    WriteLine("");
                }
                else if (userInput == 'c')
                {
                    menu.ViewOnlineHelp();
                    WriteLine("");
                }
                else if (userInput == 'u')
                {
                    gameControl.SetCommand(undoBoard);
                    gameControl.InvokeCommand();
                }
                else if (userInput == 'r')
                {
                    gameControl.SetCommand(redoBoard);
                    gameControl.InvokeCommand();
                }
                else if (userInput == 'q')
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    WriteLine("Invalid field, please try again.");
                }
            }


        }
    }

}

