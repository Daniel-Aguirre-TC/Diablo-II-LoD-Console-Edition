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
            GreetUser();
            player = new Player(GetPlayerName(), Player.PlayerClass.Barbarian);
            world = WorldFactory.CreateWorld();
            LocationHandler.ChangeLocation(0, 0);
        }

        // TODO: Replace temporary method for getting player name, later on move this into the normal game UI with name, class, and class dependant stats set to ??? until values set.
        public static string GetPlayerName()
        {
            Console.WriteLine("We will start by creating your player. In later versions I may add classes but for now we'll keep\nit simple. Please enter your charaters name:\n");
            string playerName = Console.ReadLine();
            Console.WriteLine($"\nYou have entered the name: {playerName}");
            Console.ReadKey();
            Console.Clear();
            return playerName;
        }
        // temporary greeting
        public static void GreetUser()
        {
            Console.WriteLine("Thank you for taking the time to play my Console Edition of one of the best games of all time.\n\nDiablo II - Lord of Destruction\n\n");
        }


    }
}
