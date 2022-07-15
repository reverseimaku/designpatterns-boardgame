using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Assignmentv2
{
    public class Menu
    {
        // ViewMenu outputs user's choice if player decides to load game, start game or exit the application
        public int ViewMenu()
        {
            
            while (true) // while loop loops back to menu if 
            {
                Clear();
                WriteLine();
                WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                WriteLine("| Welcome to Two Player Board Games: C# Edition! | ");
                WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                WriteLine();
                WriteLine("Current game available: Gomoku");
                WriteLine();
                WriteLine();
                WriteLine();
                WriteLine("~~~~~~~~~~~~~~~~~~~~ MENU ~~~~~~~~~~~~~~~~~~~~~~~");
                WriteLine();
                WriteLine("Please make a selection.");
                WriteLine("1. Play Gomoku");
                WriteLine("2. Load Game");
                WriteLine("3. Help");
                WriteLine("4. Game Rules");
                WriteLine("5. Exit");
                Write("Type your Selection Here > ");
                string selection = ReadLine();
                WriteLine();
                //check if selection 
                int menuChoice;

                //checkChoiceNum helps check if selection is integer and outputs menuChoice
                //if user inputs a string outside of a number, menuChoice becomes 0
                bool checkChoiceNum = int.TryParse(selection, out menuChoice);
                if (menuChoice == 1 || menuChoice == 2 || menuChoice == 5)
                {
                    return menuChoice;
                }
                else if (menuChoice == 3)
                {
                    ViewOnlineHelp();
                }

                else if (menuChoice == 4)
                {
                    ViewRules();
                }
                else
                {
                    WriteLine("Choice is invalid. Please try again.");
                    WriteLine("");
                }
            }

        }

        //ViewOnlineHelp displays help regarding this application.
        public void ViewOnlineHelp()
        {
            WriteLine();
            WriteLine("~~~~~~~~~~~~~~~~~~~~ HELP ~~~~~~~~~~~~~~~~~~~~~~~");
            WriteLine();
            WriteLine();
            WriteLine("          --- SELECTING OPTIONS ---");
            WriteLine();
            WriteLine("For every move the player makes, the player has a chance to choose each option.");
            WriteLine();
            WriteLine();
            WriteLine("            --- BOARD PIECES ---");
            WriteLine("This application is intended to have only 2 players;");
            WriteLine("Player 1 takes Board piece X.");
            WriteLine("Player 2 or Computer player takes Board piece O.");
            WriteLine();
            WriteLine("            --- PLACING PIECES ---");
            WriteLine("To place pieces, look at the number of the row, and the number of the column, and enter both of them.");
            WriteLine("For example, in Gomoku:");
            WriteLine("");

            WriteLine("Player will input as follows:");
            WriteLine("Enter row > 5");
            WriteLine("Enter column > 0");
            WriteLine("");
            WriteLine("The board would then be as follows");
            WriteLine("X. | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |10 |11 |12 |13 |14 |");
            WriteLine("");
            WriteLine("0. |   |   |   |   |   |   |   |   |   |   |   |   |   |   |   |");
            WriteLine("1. |   |   |   |   |   |   |   |   |   |   |   |   |   |   |   |");
            WriteLine("2. |   |   |   |   |   |   |   |   |   |   |   |   |   |   |   |");
            WriteLine("3. |   |   |   |   |   |   |   |   |   |   |   |   |   |   |   |");
            WriteLine("4. |   |   |   |   |   |   |   |   |   |   |   |   |   |   |   |");
            WriteLine("5. | X |   |   |   |   |   |   |   |   |   |   |   |   |   |   |");
            WriteLine("6. |   |   |   |   |   |   |   |   |   |   |   |   |   |   |   |");
            WriteLine("7. |   |   |   |   |   |   |   |   |   |   |   |   |   |   |   |");
            WriteLine("8. |   |   |   |   |   |   |   |   |   |   |   |   |   |   |   |");
            WriteLine("9. |   |   |   |   |   |   |   |   |   |   |   |   |   |   |   |");
            WriteLine("10. |   |   |   |   |   |   |   |   |   |   |   |   |   |   |   |");
            WriteLine("11. |   |   |   |   |   |   |   |   |   |   |   |   |   |   |   |");
            WriteLine("12. |   |   |   |   |   |   |   |   |   |   |   |   |   |   |   |");
            WriteLine("13. |   |   |   |   |   |   |   |   |   |   |   |   |   |   |   |");
            WriteLine("14. |   |   |   |   |   |   |   |   |   |   |   |   |   |   |   |");
            WriteLine();

            WriteLine("~~~~~~~~~~~~~~~~~~~~ END OF HELP ~~~~~~~~~~~~~~~~~~~~~~~");
            WriteLine();
        }

        public int PlayerSelect()
        {
            //disconnects with the action; if you add 1 more game then you need to add in more places
            //as long as it works

            //under player select in menu class
            while (true)
            {
                WriteLine("Please choose from the following:");
                WriteLine("1. Play against another person");
                WriteLine("2. Play against computer");
                WriteLine("3. Back to Menu");
                Write("Type your Selection Here > ");
                string selectNum = ReadLine();
                WriteLine();
                WriteLine();
                bool checkChoiceNum = int.TryParse(selectNum, out int menuChoice);
                if (menuChoice ==1 || menuChoice ==2)
                {
                    return menuChoice;
                }
                if (menuChoice ==3)
                {
                    ViewMenu();
                }
                else
                {
                    WriteLine("Invalid field, please try again.");
                }
            }

        }
        public void ViewRules()
        {
            WriteLine();
            WriteLine("Select which game to view its rules on.");
            WriteLine();
            WriteLine("1. Gomoku");
            WriteLine("2. Back to Menu");

            int menuChoice = Convert.ToInt32(ReadLine());

            while (true)
            {
                if (menuChoice == 1)
                {
                    Gomoku gomoku = new Gomoku();
                    Clear();
                    WriteLine();
                    WriteLine("~~~~~~~~~~~~~~~~~~~~ GAME RULES ~~~~~~~~~~~~~~~~~~~~~~~");
                    WriteLine();
                    WriteLine();
                    WriteLine("                  --- GOMOKU ---");
                    WriteLine();
                    gomoku.GameRules();
                    break;
                }
                if (menuChoice == 2)
                {
                    ViewMenu();
                    break;
                }
                else
                {
                    WriteLine("Invalid Choice. Please try again.");
                }
            }



        }

        //command pattern: when player selected, initialise player2 human class.
        //when computer selected, initialise computer class.
        //both are abstract classes; human class overrides method placepiece.
        //computer overrides method placepiece.

    }

}
