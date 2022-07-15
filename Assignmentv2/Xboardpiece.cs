using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmentv2
{
    public class Xboardpiece : Boardpiece
    {
        public char x = 'X';

        public char Piece { get { return x; } }

        public char BPiece()
        {
            return Piece; //solely gets X piece
        }
    }
}
