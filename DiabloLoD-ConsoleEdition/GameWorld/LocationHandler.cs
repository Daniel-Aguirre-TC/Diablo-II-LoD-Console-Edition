using System;
using System.Collections.Generic;
using System.Text;

namespace DiabloLoD_ConsoleEdition.GameWorld
{
    public static class LocationHandler
    {
        public static Location currentLocation;
        static World world { get { return GameManager.world; } }


        public static void ChangeLocation(int xCoordinate, int yCoordinate)
        {
            currentLocation = world.LocationAt(xCoordinate, yCoordinate);
            ConsoleHandler.NewOptionList(currentLocation.options);
        }

    }
}
