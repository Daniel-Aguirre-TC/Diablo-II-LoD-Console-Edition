using System;
using System.Collections.Generic;
using System.Text;

namespace DiabloLoD_ConsoleEdition.UserCommands
{
    
    public static class CommandsFactory
    {

        
        public static void CreateCommands(CommandsLibrary commandLibrary)
        {
            

            commandLibrary.AddCommandsToList
                (
                commandLibrary.rogueEncampmentCommands,
                new Commands("Talk to Warriv", "You approach Warriv, the Caravan Traveler.", commandLibrary.warrivDialogCommands, Commands.CommandType.Dialog),
                new Commands("Travel East", "", commandLibrary.bloodMooreEntranceCommands, Commands.CommandType.Travel)
                );

            commandLibrary.AddCommandsToList
                (
                commandLibrary.warrivDialogCommands,
                new Commands("Return To Town", "You depart from Warriv.", commandLibrary.rogueEncampmentCommands, Commands.CommandType.Dialog),
                new Commands("Introduction", "Greetings, stranger. I'm not surprised to see your kind here. No doubt you've heard about the tragedy that befell the town of Tristram. Some say that Diablo, the Lord of Terror, walks again. I don't know if I believe that, but a Dark Wanderer did travel this route a few weeks ago. He was headed east to the mountain pass guarded by the Rogue Monastery. Maybe it's nothing, but evil seems to have trailed in his wake. You see, shortly after the Wanderer went through, the Monastery's Gates to the pass were closed and strange creatures began ravaging the countryside. Until it's safer outside the camp and the gates are re-opened, I'll remain here with my caravan. I hope to leave for Lut Gholein before the shadow that fell over Tristram consumes us all. If you're still alive then, I'll take you along. You should talk to Akara, too. She seems to be the leader of this camp. Maybe she can tell you more.", commandLibrary.warrivDialogCommands, Commands.CommandType.Dialog)
                );

            commandLibrary.AddCommandsToList
                (
                commandLibrary.bloodMooreEntranceCommands,
                new Commands("Travel East", "", commandLibrary.bloodMooreCommands, Commands.CommandType.Travel),
                new Commands("Travel West", "", commandLibrary.rogueEncampmentCommands, Commands.CommandType.Travel)
                );

            commandLibrary.AddCommandsToList
                (
                commandLibrary.bloodMooreCommands,
                new Commands("Travel West", "", commandLibrary.bloodMooreEntranceCommands, Commands.CommandType.Travel)
                );




        }

        
        

    }
}
