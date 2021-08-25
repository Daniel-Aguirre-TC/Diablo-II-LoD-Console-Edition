using System;
using System.Collections.Generic;
using System.Text;

namespace DiabloLoD_ConsoleEdition.UserCommands
{
    public static class DialogCommands
    {
        public static List<Commands> warrivDialog = new List<Commands>()
        {
            new Commands("Introduction", "Greetings, stranger. I'm not surprised to see your kind here. Many adventurers have traveled this way since the recent troubles began. \nNo doubt you've heard about the tragedy that befell the town of Tristram. Some say that Diablo, the Lord of Terror, walks again. \nI don't know if I believe that, but a Darkr Wanderer did travel this route a few weeks ago. He was headed east to the mountain pass guarded by the Rogue Monastery. \nMaybe it's nothing, but evil seems to have trailed in his wake. You see, shortly after the Wanderer went through, the Monastery's Gates to the pass were closed and strange creatures began ravaging the countryside. \nUntil it's safer outside the camp and the gates are re-opened, I'll remain here with my caravan. I hope to leave for Lut Gholein before the shadow that fell over Tristram consumes us all. If you're still alive then, I'll take you along. \nYou should talk to Akara, too. She seems to be the leader of this camp. Maybe she can tell you more.",
                LocationCommands.RogueEncampmentCommands, Commands.CommandType.Dialog)
        };
    }
}
