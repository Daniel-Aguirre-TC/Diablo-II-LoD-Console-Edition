using System;
using System.Collections.Generic;
using System.Text;
using DiabloLoD_ConsoleEdition.UserCommands;

namespace DiabloLoD_ConsoleEdition.GameWorld
{
    public class World
    {
        private List<Location> locations = new List<Location>();
        
        /*
            I'm storing my locations here, which has a list of locationCommands. I don't have a list of dialogCommands
            that gets stored in the world. So this could be where my null is coming from, because I'm never actually instantiating the list
            that I'm referencing.

            I think it would be beneficial to link the NPC to the location, so we can create an NPC class that holds a list of commands.
            then we will instantiate the NPC class inside of the WorldFactory when we add the location that holds the NPC.
         
            Each location may hold multiple NPCs so I need to provide it with a List<NPC>.

            Then when I need to access the List of Commands, I would access location.NpcList(specificNPC).commandList ???
        
        */

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
