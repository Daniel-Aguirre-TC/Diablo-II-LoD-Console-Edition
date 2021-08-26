using System;
using System.Collections.Generic;
using System.Text;

namespace DiabloLoD_ConsoleEdition.UserCommands
{
    public class CommandsLibrary
    {
        public List<Commands> rogueEncampmentCommands = new List<Commands>();
        public List<Commands> warrivDialogCommands = new List<Commands>();
        public List<Commands> bloodMooreEntranceCommands = new List<Commands>();
        public List<Commands> bloodMooreCommands = new List<Commands>();
               

        public void AddCommandsToList(List<Commands> listAddingTo,params Commands[] commandsAdding)
        {
            foreach (var command in commandsAdding)
            {
                listAddingTo.Add(command);
            }
        }

    }
}
