using System;
using System.Collections.Generic;
using System.Text;

namespace DiabloLoD_ConsoleEdition.UserCommands
{
    public static class LocationCommands
    {
        public static List<Commands> RogueEncampmentCommands = new List<Commands>()
        {
            new Commands("Talk to Warriv", "You approach Warriv, the Caravan Traveler.", DialogCommands.warrivDialog),
            new Commands("Travel East", "", BloodMooreEntranceCommands)
        };

        public static List<Commands> BloodMooreEntranceCommands = new List<Commands>()
        {
            new Commands("Travel West", "", RogueEncampmentCommands),
            new Commands("Travel East", "", BloodMooreCommands)
        };

        public static List<Commands> BloodMooreCommands = new List<Commands>()
        { new Commands("Travel West", "", RogueEncampmentCommands)
        };

        static void AddCommandToLocation(Commands commandAdding, List<Commands> listAddingTo)
        {
            listAddingTo.Add(commandAdding);
        }

    }
}
