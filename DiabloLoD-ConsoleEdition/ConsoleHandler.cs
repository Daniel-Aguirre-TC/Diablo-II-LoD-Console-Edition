using System;
using System.Collections.Generic;
using System.Text;
using DiabloLoD_ConsoleEdition.GameWorld;
using DiabloLoD_ConsoleEdition.UserCommands;

namespace DiabloLoD_ConsoleEdition
{
    public static class ConsoleHandler
    {
        static List<Commands> commandsBeingDisplayed = new List<Commands>();
        static List<string> stringsBeingDisplayed = new List<string>();
        //padding values for drawing the gui
        static int namePadding = 24;
        static int locationPadding = 33;
        static int statPadding = 18;
        static int resistPadding = 11;
        static int messagePadding = 52;
        static int optionPadding = 95;
        // the maximum length that a string can be for a message, otherwise it is chopped into multiple strings.
        static int messageCharLimit = 49;
        // maximum number of lines that can display strings for messages.
        static int maxMessagesShown = 22;

        static bool reprintForInvalidSelection = false;
        

        // DisplayText should be called if we are needing to print a new message to the page.
        public static void PrintNewMessage(string message, bool clearExistingMessages)
        {
            
            string[] formattedMessage = FormatMessage(message, messageCharLimit);
            if(clearExistingMessages)
            { stringsBeingDisplayed.Clear(); }
            AddMsgToDisplayList(formattedMessage);
            DrawPage();
            
        }


        // print new options list - bool reloadPage included in case we are using this when changing location since ChangeLocation will handle reprint
        public static void NewOptionList(List<Commands> commands, bool reloadPage)
        {
            commandsBeingDisplayed.Clear();
            foreach(Commands command in commands)
            {
                commandsBeingDisplayed.Add(command);
            }
            if(reloadPage)
            {
                DrawPage();
            }
            
        }

        static void AddMsgToDisplayList(string[] messages)
        {
            foreach(string message in messages)
            {

                for(int i = stringsBeingDisplayed.Count - 1; i >= 0; i--)
                {
                    if (stringsBeingDisplayed[i] == PadUntilThenColumn("", messagePadding))
                    {
                        stringsBeingDisplayed.Remove(stringsBeingDisplayed[i]);
                    }
                }
                // if at maxMessagesShown
                if(stringsBeingDisplayed.Count == maxMessagesShown)
                {
                    // then remove the top message
                    stringsBeingDisplayed.RemoveAt(0);
                }
                // add string message to DisplayList
                stringsBeingDisplayed.Add(PadUntilThenColumn(message, messagePadding));
            }
        }
  
        // prints the page, should only be called by methods inside the ConsoleHandler. 
        static void DrawPage()
        {
            string playerName = PadUntilThenColumn(GameManager.player.name, namePadding);
            string locationName = PadUntilThenColumn(LocationHandler.currentLocation.name, locationPadding);
            string playerClass = PadUntilThenColumn(GameManager.player.playerClass.ToString(), statPadding);
            string playerLevel = PadUntilThenColumn(GameManager.player.level.ToString(), statPadding);
            string playerExp = PadUntilThenColumn(GameManager.player.experience.ToString(), statPadding);
            string playerHealth = PadUntilThenColumn(GameManager.player.currentHealth.ToString() + " / " + GameManager.player.maxHealth, statPadding);
            string playerMana = PadUntilThenColumn(GameManager.player.currentMana.ToString() + " / " + GameManager.player.maxMana, statPadding);
            string playerStr = PadUntilThenColumn(GameManager.player.str.ToString(), statPadding);
            string playerDex = PadUntilThenColumn(GameManager.player.dex.ToString(), statPadding);
            string playerVit = PadUntilThenColumn(GameManager.player.vit.ToString(), statPadding);
            string playerMagic = PadUntilThenColumn(GameManager.player.magic.ToString(), statPadding);
            string fireResist = PadUntilThenColumn(GameManager.player.fireResist.ToString(), resistPadding);
            string coldResist = PadUntilThenColumn(GameManager.player.coldResist.ToString(), resistPadding);
            string lightResist = PadUntilThenColumn(GameManager.player.lightResist.ToString(), resistPadding);
            string poisonResist = PadUntilThenColumn(GameManager.player.poisonResist.ToString(), resistPadding);
            // in not all lines are being used then add empty messages to the bottom of the list.
            while (stringsBeingDisplayed.Count < maxMessagesShown)
            {
                stringsBeingDisplayed.Add(PadUntilThenColumn("", messagePadding));
            }

            Console.Clear();
             Console.WriteLine("  _______________________________________________________________________________________________ ");
             Console.WriteLine("  |   ______________________________     _____________________________________________________   |");
             Console.WriteLine("  |  /                              \\   /                                                     \\  |");
            Console.WriteLine($"  | |  Name: {playerName}    Current Location: {locationName}");
             Console.WriteLine("  |  \\______________________________/   \\_____________________________________________________/  |");
             Console.WriteLine("  |   ______________________________     _____________________________________________________   |");
             Console.WriteLine("  |  /                              \\   /                                                     \\  |");
            Console.WriteLine($"  | |      Class:  {playerClass}   {stringsBeingDisplayed[0]}");
            Console.WriteLine($"  | |      Level:  {playerLevel}   {stringsBeingDisplayed[1]}");
            Console.WriteLine($"  | |        Exp:  {playerExp}   {stringsBeingDisplayed[2]}");
            Console.WriteLine($"  |  \\______________________________/  |   {stringsBeingDisplayed[3]}");
            Console.WriteLine($"  |   ______________________________   |   {stringsBeingDisplayed[4]}");
            Console.WriteLine($"  |  /                              \\  |   {stringsBeingDisplayed[5]}");
            Console.WriteLine($"  | |     Health:  {playerHealth}   {stringsBeingDisplayed[6]}");
            Console.WriteLine($"  | |       Mana:  {playerMana}   {stringsBeingDisplayed[7]}");
            Console.WriteLine($"  |  \\______________________________/  |   {stringsBeingDisplayed[8]}");
            Console.WriteLine($"  |   ______________________________   |   {stringsBeingDisplayed[9]}");
            Console.WriteLine($"  |  /                              \\  |   {stringsBeingDisplayed[10]}");
            Console.WriteLine($"  | |   Strength:  {playerStr}   {stringsBeingDisplayed[11]}");
            Console.WriteLine($"  | |  Dexterity:  {playerDex}   {stringsBeingDisplayed[12]}");
            Console.WriteLine($"  | |   Vitality:  {playerVit}   {stringsBeingDisplayed[13]}");
            Console.WriteLine($"  | |      Magic:  {playerMagic}   {stringsBeingDisplayed[14]}");
            Console.WriteLine($"  |  \\______________________________/  |   {stringsBeingDisplayed[15]}");
            Console.WriteLine($"  |   ______________________________   |   {stringsBeingDisplayed[16]}");
            Console.WriteLine($"  |  /                              \\  |   {stringsBeingDisplayed[17]}");
            Console.WriteLine($"  | |        Fire Resist: {fireResist}   {stringsBeingDisplayed[18]}");
            Console.WriteLine($"  | |        Cold Resist: {coldResist}   {stringsBeingDisplayed[19]}");
            Console.WriteLine($"  | |   Lightning Resist: {lightResist}   {stringsBeingDisplayed[20]}");
            Console.WriteLine($"  | |      Poison Resist: {poisonResist}   {stringsBeingDisplayed[21]}");
            Console.WriteLine($"  |  \\______________________________/   \\_____________________________________________________/  |");
             Console.WriteLine("  |   ________________________________________________________________________________________   |");
             Console.WriteLine("  |  /                                                                                        \\  |");
             Console.WriteLine("  | |                             Please Enter An Option Shown Below:                          | |");
            PrintOptions();
            Console.WriteLine($"  |  \\________________________________________________________________________________________/  |");
             Console.WriteLine("  |______________________________________________________________________________________________|");

            if(!reprintForInvalidSelection)
            {
                InputHandler.GetUserInput(commandsBeingDisplayed.ToArray());
            }


            
        }

        // PrintOptions() is nested inside of DrawPage() because it should only ever be called by this method.
        static void PrintOptions()
        {
            int currentOptionNumber = 0;
            foreach (Commands option in commandsBeingDisplayed)
            {
                Console.WriteLine(($"  | |    {currentOptionNumber} )  {option.name} ").PadRight(optionPadding) + "| |");
                currentOptionNumber++;
            }
        }

        // used to reprint the page if an invalid option was chosen.
        public static void InvalidOptionChosen()
        {
            reprintForInvalidSelection = true;
            DrawPage();
            reprintForInvalidSelection = false;
        }

        // if a message is too long then this will chop it into multiple strings before displaying on the page.
        static string[] FormatMessage(string message, int charLimit)
        {
            string stringToChop = message;
            List<string> splitMessagesToDisplay = new List<string>();
            // if the message doesn't need to be chopped
            if (stringToChop.Length <= charLimit)
            {
                // add message to list to be returned as string[]
                splitMessagesToDisplay.Add(stringToChop);
            }
            // Else string is too long so we will chop it
            else
            {
                // used to move index forward
                int subcycle =  0;
                //While Msg too Long
                while (stringToChop.Length > charLimit)
                {
                    // used used to move forward one char each loop starting at the end of the message
                    int index = charLimit - subcycle;
                    // If index = ' ' 
                    if (stringToChop[index] == ' ')        
                    {
                        // then create a Substring from 0 up to index
                        string tempmsg = stringToChop.Substring(0, index);
                        // add chopped message to splitMsgList
                        splitMessagesToDisplay.Add(tempmsg);
                        // remove the section we just copied and the ' ' to splitMsgList
                        stringToChop = stringToChop.Remove(0, index + 1);
                        // reset subCycle so that you can start index at the end of the string again if message is still too long.
                        subcycle = 0;
                    }
                    // else if index is not at a space, will increase subcycle which will move the index forward.
                    else { subcycle++; }
                }
                // if message is now less than or equal to where we want to start padding
                if (stringToChop.Length <= charLimit)
                {
                    splitMessagesToDisplay.Add(stringToChop);
                }
            }
            return splitMessagesToDisplay.ToArray();
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

        public static void ShowLogo()
        {
            string spacing = "                                     ";
            // Logo, cause why not?

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine($"{spacing}   ______    ______   ____ ");
            Console.WriteLine($"{spacing}   |    |    |       |    \\");
            Console.WriteLine($"{spacing}   |    |    |       |     \\");
            Console.WriteLine($"{spacing}   ------    |-----  |     |");
            Console.WriteLine($"{spacing}   |     \\   |       |     |");
            Console.WriteLine($"{spacing}   |      \\  |_____  |_____|\n");

            Console.WriteLine($"{spacing}______    ______   _____   _     ");
            Console.WriteLine($"{spacing}|    |    |     |    |    | \\   |");
            Console.WriteLine($"{spacing}|    |    |     |    |    |  \\  |");
            Console.WriteLine($"{spacing}------    |-----|    |    |   \\ |");
            Console.WriteLine($"{spacing}|     \\   |     |    |    |    \\|");
            Console.WriteLine($"{spacing}|      \\  |     |  __|__  |     |");

            // will say press any key to begin or exit depending on if starting or ending game.
            string beginOrExit = GameManager.isPlaying ? "Begin" : "Exit";
            Console.Write($"\n\n{spacing}    Press Any Key To {beginOrExit}.");
            Console.ReadKey();
            Console.Clear();
        }
        public static string PadUntilThenColumn(string stringToPad, int indexToPadTo)
        {
            while (stringToPad.Length < indexToPadTo)
            { stringToPad += " "; }
            return stringToPad + "| |";
        }

    }


}
