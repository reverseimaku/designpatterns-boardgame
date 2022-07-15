using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace Assignmentv2
{
    public interface Game
    {
        char[,] GArray { get; }
        public void GameRules();
        public void InitialiseGame(char[,] board);
        public void ContinueGame(char[,] board);
        public void WinCondition(char[,] board);
    }

}
