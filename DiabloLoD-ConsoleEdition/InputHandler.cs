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
            // consoleHandler.SetUserOptions()
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
                    if (reply == option.name || reply.ToLower() == option.name || reply == optionCounter.ToString() )
                    { validResponse = true;
                        ConsoleHandler.NewOptionList(option.nextCommands);
                        ConsoleHandler.DisplayText(option.messageOutput, false);
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
