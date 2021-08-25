using System;
using System.Collections.Generic;
using System.Text;

namespace DiabloLoD_ConsoleEdition.UserCommands
{
    public class Commands
    {  
        // command type to proccess the needed changes based on command.
        // dialog for just adding new message and options to the page.
        // travel for moving to new location and displaying that locations options.
        // fighting type or perhaps action type to be added at later time for fighting and exploring currentLocation
        public enum CommandType { Dialog, Travel,}
        public CommandType type;
        public string name;
        public string messageOutput;
        public List<Commands> nextCommands = new List<Commands>();

        public Commands(string Name, string MessageOutput, List<Commands> NextCommands, CommandType commandType)
        {
            name = Name;
            messageOutput = MessageOutput;
            nextCommands = NextCommands;
            type = commandType;
        }


        
    }
}
