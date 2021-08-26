using System;
using System.Collections.Generic;
using System.Text;
using DiabloLoD_ConsoleEdition.UserCommands;

namespace DiabloLoD_ConsoleEdition.GameWorld
{
    public static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World world = new World();
            world.AddLocation(0, 0, "Rogue Encampment",
                "You find yourself on the edges of Blood Moore, in the Rogue Encampment, a resting place for the survivors from the Rogue Monastary. Here you can find Charsi the Blacksmith, Gheed the Merchant, Akara the High Priestess, Kashya the Captain of the Rogue Archers, and Warriv the Caravan Traveler.",
                GameManager.commandsLibrary.rogueEncampmentCommands);

            world.AddLocation(1, 0, "Blood Moore Entrance",
                "You stop to rest on the bridge between Blood Moore and the Rogue Encampment. To the West is the safety of the Rogue Encampment. From the East you can hear horrid demons and otherworldy monsters ravaging the lands.",
                GameManager.commandsLibrary.bloodMooreEntranceCommands);

            world.AddLocation(2, 0, "Blood Moore",
                "In the distance you can hear the screams of the innocent, the chittering from the spined fiends, and the howling of the fallen ones.",
                GameManager.commandsLibrary.bloodMooreCommands);

            return world;
        }

    }
}
