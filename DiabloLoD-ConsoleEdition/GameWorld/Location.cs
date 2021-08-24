using System;
using System.Collections.Generic;
using System.Text;
using DiabloLoD_ConsoleEdition.UserCommands;

namespace DiabloLoD_ConsoleEdition.GameWorld
{
    public class Location
    {
        public int xCoordinate;
        public int yCoordinate;
        public string name;
        public string description;
        public List<Commands> locationCommands;
    }
}
