using System;
using System.Collections.Generic;
using System.Text;

namespace DiabloLoD_ConsoleEdition.GameWorld
{
    public static class LocationHandler
    {
        public static Location currentLocation;
        static World world { get { return GameManager.world; } }


        // this method will handle changing location, printing the new locations message, and printing its commands.
        public static void ChangeLocation(int xCoordinate, int yCoordinate)
        {
            currentLocation = world.LocationAt(xCoordinate, yCoordinate);
            // Display new option list - this does not clear the existing messages but does reprint the page again.
            ConsoleHandler.NewOptionList(currentLocation.locationCommands, false);
            // clear message list when changing location and display Location.Description
            ConsoleHandler.PrintNewMessage(currentLocation.description, true);
        }

        // use the commandName to change location depending on direction.
        public static void ChangeLocation(string commandName)
        {
            switch (commandName)
            {
                case "Travel North":
                        ChangeLocation(currentLocation.xCoordinate, currentLocation.yCoordinate + 1);
                    break;
                case "Travel East":
                    ChangeLocation(currentLocation.xCoordinate + 1, currentLocation.yCoordinate);
                    break;
                case "Travel South":
                    ChangeLocation(currentLocation.xCoordinate, currentLocation.yCoordinate -1);
                    break;
                case "Travel West":
                    ChangeLocation(currentLocation.xCoordinate - 1, currentLocation.yCoordinate);
                    break;
                default:
                    Console.WriteLine($"ERROR MOVING LOCATION. NO CASE SET UP FOR {commandName}");
                    break;
            }
        }

    }
}
