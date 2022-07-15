using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Assignmentv2
{
    class GameProgram // Puts it all together
    {
        public static void MainProgram()
        {

            Player player1 = new HumanFactory().GetPlayer();
            Player player2h = new HumanFactory().GetPlayer();
            Player player2c = new ComputerFactory().GetPlayer();

            GameControl gameControl = new GameControl();

            Menu menu = new Menu();
            int menuChoice;
            int playerSelectChoice;
            Board gBoard = new Board();

            Game gomoku = new GomokuFactory().MakeGame();


            while (true)
            {
                menuChoice = menu.ViewMenu();

                char userInput = ' ';

                while (true)
                {
                    if (menuChoice == 1)
                    {
                        playerSelectChoice = menu.PlayerSelect();

                        if (playerSelectChoice == 1) //Human vs Human
                        {
                            WriteLine();
                            WriteLine("Enter Player 1's Name:");
                            Write("> ");
                            player1.Name = ReadLine();
                            WriteLine();
                            WriteLine("Enter Player 2's Name:");
                            Write("> ");
                            player2h.Name = ReadLine();
                            Clear();
                            gomoku.InitialiseGame(gomoku.GArray);

                            ControlHvH(gBoard, gomoku, player1, player2h);


                        }
                        if (userInput == 'm')
                        {
                            MainProgram();
                        }

                        else if (playerSelectChoice == 2) //Human vs computer
                        {
                            WriteLine();
                            WriteLine("Enter Player 1's Name:");
                            Write("> ");
                            player1.Name = ReadLine();
                            Clear();
                            gomoku.InitialiseGame(gomoku.GArray);


                            ControlCvH(gBoard, gomoku, player1, player2c);

                        }
                    }
                    else if (menuChoice == 2)
                    {
                        Clear();
                        gameControl.SetCommand(new LoadBoardCommand(gomoku.GArray));
                        gameControl.InvokeCommand();

                        gomoku.ContinueGame(gomoku.GArray);
                        ControlHvH(gBoard, gomoku, player1, player2h);
                        break;
                    }
                    else if (menuChoice == 4)
                    {
                        System.Environment.Exit(0);
                    }
                }
            }


        }
    
        public static void ControlCvH(Board gBoard, Game game, Player player1, Player player2c)
        {
            Menu menu = new Menu();
            char userInput = ' ';
            GameControl gameControl = new GameControl();
            Boardpiece xbp = new XboardpieceFactory().CreatePiece();
            Boardpiece obp = new OboardpieceFactory().CreatePiece();


            while (true)
            {
                WriteLine();
                WriteLine("Player {0}'s turn", player1.Name);
                WriteLine("Enter the key for your next action.");
                gBoard.GamePrompts(ref userInput, menu, game, gameControl);

                if (userInput == 'm')
                {
                    MainProgram();
                }
                gameControl.SetCommand(new PlacePieceCommand(game.GArray, player1, game, xbp));
                gameControl.InvokeCommand();
                gameControl.SetCommand(new PlacePieceCommand(game.GArray, player2c, game, obp));
                gameControl.InvokeCommand();
            }

        }

        public static void ControlHvH(Board gBoard, Game game, Player player1, Player player2h) //human vs human
        {
            Menu menu = new Menu();
            char userInput = ' ';
            GameControl gameControl = new GameControl();
            Boardpiece xbp = new XboardpieceFactory().CreatePiece();
            Boardpiece obp = new OboardpieceFactory().CreatePiece();

            while (true)
            {
                WriteLine();

                WriteLine("Player {0}'s turn", player1.Name);
                WriteLine("Enter the key for your next action.");
                gBoard.GamePrompts(ref userInput, menu, game, gameControl);

                if (userInput == 'm')
                {
                    Clear();
                    MainProgram();
                }
                gameControl.SetCommand(new PlacePieceCommand(game.GArray, player1, game, xbp));
                gameControl.InvokeCommand();

                WriteLine("Player {0}'s turn", player2h.Name);
                WriteLine("Enter the key for your next action.");
                gBoard.GamePrompts(ref userInput, menu, game, gameControl);
                gameControl.SetCommand(new PlacePieceCommand(game.GArray, player2h, game, obp));
                gameControl.InvokeCommand();


            }
        }
    }
}
