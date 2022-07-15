using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmentv2
{
    public abstract class BoardpieceFactory
    {
        protected abstract Boardpiece MakePiece();

        public Boardpiece CreatePiece()
        {
            return this.MakePiece();
        }

    }

}
