using System;
using System.Collections.Generic;
using System.Text;
using DiabloLoD_ConsoleEdition.UserCommands;

namespace DiabloLoD_ConsoleEdition.GameWorld
{
    public class World
    {
        private List<Location> locations = new List<Location>();


        public void AddLocation(int xCoordinate, int yCoordinate, string name, string description, List<Commands> commands)
        {
            Location location = new Location();
            location.xCoordinate = xCoordinate;
            location.yCoordinate = yCoordinate;
            location.name = name;
            location.description = description;
            location.locationCommands = commands;
            
            locations.Add(location);
        }



        public Location LocationAt(int xCoordinate, int yCoordinate)
        {
            foreach (Location location in locations)
            {
                if(location.xCoordinate == xCoordinate && location.yCoordinate == yCoordinate)
                {
                    return location;
                }
            }
            // if no location at provided Coordinates, then return null
            return null;
        }
    }
}
