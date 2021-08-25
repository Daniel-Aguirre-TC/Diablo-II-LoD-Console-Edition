using System;
using System.Collections.Generic;
using System.Text;

namespace DiabloLoD_ConsoleEdition.UserCommands
{
    public static class LocationCommands
    {
        public static List<Commands> RogueEncampmentCommands = new List<Commands>()
        {
            new Commands("Talk to Warriv", "You approach Warriv, the Caravan Traveler.", DialogCommands.warrivDialog, Commands.CommandType.Dialog),
            new Commands("Travel East", "", BloodMooreEntranceCommands, Commands.CommandType.Travel)
        };

        public static List<Commands> BloodMooreEntranceCommands = new List<Commands>()
        {
            new Commands("Travel West", "", RogueEncampmentCommands, Commands.CommandType.Travel),
            new Commands("Travel East", "", BloodMooreCommands, Commands.CommandType.Travel)
        };

        public static List<Commands> BloodMooreCommands = new List<Commands>()
        { new Commands("Travel West", "", RogueEncampmentCommands, Commands.CommandType.Travel)
        };

        static void AddCommandToLocation(Commands commandAdding, List<Commands> listAddingTo)
        {
            listAddingTo.Add(commandAdding);
        }


        //public static void CloneList(List<Commands> listToClone)

    }
}
