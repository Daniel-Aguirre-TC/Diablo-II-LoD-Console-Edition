using System;
using System.Collections.Generic;
using System.Text;
using DiabloLoD_ConsoleEdition.GameWorld;
using DiabloLoD_ConsoleEdition.UserCommands;

namespace DiabloLoD_ConsoleEdition
{
    public static class InputHandler
    {

        public static string GetUserInput(params Commands[] validOptions)
        {
            string reply = "";
            bool validResponse = false;
            int optionCounter = 0;
            bool secondIncorrectAnswer = false;
            while (!validResponse)
            {
                reply = Console.ReadLine();
                if (secondIncorrectAnswer)
                { ConsoleHandler.InvalidOptionChosen(); }
                foreach (Commands option in validOptions)
                {
                    if (reply.ToLower() == option.name.ToLower() || reply == optionCounter.ToString() )
                    { validResponse = true;
                        switch(option.type)
                        {
                            // if command is for travel, then change location
                            case Commands.CommandType.Travel:
                                LocationHandler.ChangeLocation(option.name);
                                break;
                                // if command is for dialog, we will just change options and print new message.
                            case Commands.CommandType.Dialog:
                                // new command list, but will not reload page yet
                                ConsoleHandler.NewOptionList(option.nextCommands, false);
                                // print new message, now will reload page
                                ConsoleHandler.PrintNewMessage(option.messageOutput, false);
                                break;
                        }
                    }
                    optionCounter++;
                }
                if(!validResponse)
                {
                    Console.WriteLine($"\n### \" {reply} \" is not a valid Selection.###\nPlease enter a valid number matching the option you wish to choose. ###.");
                    secondIncorrectAnswer = true;
                    optionCounter = 0;
                }
            }
            return reply;
            
        }

    }
}
