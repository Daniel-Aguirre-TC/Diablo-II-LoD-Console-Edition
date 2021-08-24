using System;
using System.Collections.Generic;
using System.Text;

namespace DiabloLoD_ConsoleEdition.UserCommands
{
    public class Commands
    {  
        public enum CommandType { Dialog, Travel, Location}
        public string name;
        public string messageOutput;
        public List<Commands> nextCommands = new List<Commands>();

        public Commands(string Name, string MessageOutput, List<Commands> NextCommands)
        {
            name = Name;
            messageOutput = MessageOutput;
            nextCommands = NextCommands;
        }


        
    }
}
