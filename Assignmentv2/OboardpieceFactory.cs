using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmentv2
{
    public class OboardpieceFactory : BoardpieceFactory
    {
        protected override Boardpiece MakePiece()
        {
            Boardpiece oboardpiece = new Oboardpiece();
            return oboardpiece;
        }
    }
}
