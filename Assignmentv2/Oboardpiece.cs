using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmentv2
{
    public class Oboardpiece : Boardpiece
    {
        private char o = 'O';
        public char Piece { get { return o; } }

        public char BPiece()
        {
            return Piece; //solely gets O piece
        }

    }
}
