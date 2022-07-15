using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Assignmentv2
{
    public class GameControl //Controls all commands
    {
        ICommand command;


        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void InvokeCommand()
        {
            command.Execute(); //InvokeCommand accesses the compulsory method of Execute within each command class
        }



    }
}
