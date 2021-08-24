using System;
using System.Collections.Generic;
using System.Text;
using DiabloLoD_ConsoleEdition.GameWorld;

namespace DiabloLoD_ConsoleEdition
{
    public static class GameManager
    {
        public static Player player;
        public static bool isPlaying;
        public static World world;

        public static void StartNewGame()
        {
            isPlaying = true;
            ConsoleHandler.ShowLogo();
            ConsoleHandler.GreetUser();
            player = new Player(ConsoleHandler.GetPlayerName(), Player.PlayerClass.Barbarian);
            world = WorldFactory.CreateWorld();
            LocationHandler.ChangeLocation(0, 0);
            ConsoleHandler.DisplayText(LocationHandler.currentLocation.description, false);
        }



    }
}
