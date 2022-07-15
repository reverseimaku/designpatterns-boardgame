using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.IO;
using System.Linq;
using System.Collections;

namespace Assignmentv2
{
    // Contains methods to save and load the board
    class GameAction
    {
        //WriteGame writes the board into a text file
        public static void WriteGame(string filename, char[,] gameboard)
        {

            Board board = new Board();
            FileStream stream = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            //write each output piece of gameboard[y,x]
            for (int y = 0; y < gameboard.GetLength(0); y++)
            {
                for (int x = 0; x < gameboard.GetLength(1); x++)
                {
                    writer.Write(gameboard[y, x]);
                }
            }
            writer.Close();
            stream.Close();
        }

        // LoadGame loads the text saved from the file
        public static void LoadGame(char[,] gameboard)
        {

            string filename = @"C:\IFN563_save\save.txt";
            StreamReader reader = new StreamReader(filename);

            int totalLength = gameboard.GetLength(0) * gameboard.GetLength(1);//total Length of game board

            char input;

            while (!reader.EndOfStream)
            {
                input = (char)reader.Read();
                char[] pieceList = new char[totalLength];

                for (int y = 0; y < gameboard.GetLength(0); y++)
                {
                    for (int x = 0; x < gameboard.GetLength(1); x++)
                    {
                        gameboard[y, x] = input;
                    }
                }
            }

            reader.Close();

            WriteLine();
            WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            WriteLine("Loading currently does not work. Reloading a new game.");
            WriteLine();
            WriteLine("X. | 0 | 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 |10 |11 |12 |13 |14 |");
            for (int y = 0; y < gameboard.GetLength(0); y++)
            {

                Write("{0}. | ", y);
                for (int x = 0; x < gameboard.GetLength(1); x++)
                {
                    Write(gameboard[y, x]);
                    Write(" | ");

                }
                WriteLine();
            }
        }

        //save game invokes WriteGame method via the filename itself
        public static void SaveGame(char[,] gameboard)
        {

            string filename = @"C:\IFN563_save\save.txt";

            WriteGame(filename, gameboard);
        }

    }
}
