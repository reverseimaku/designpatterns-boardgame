using System;
using System.Collections.Generic;
using System.Text;

namespace Assignmentv2
{
    public class XboardpieceFactory : BoardpieceFactory
    {
        protected override Boardpiece MakePiece()
        {
            Boardpiece xboardpiece = new Xboardpiece();
            return xboardpiece;
        }
    }
}
