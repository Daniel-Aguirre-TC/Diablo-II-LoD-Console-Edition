using System;
using System.Collections.Generic;
using System.Text;
using DiabloLoD_ConsoleEdition.GameItems;

namespace DiabloLoD_ConsoleEdition
{

    public class Player
    {
        public enum PlayerClass { Amazon, Assassin, Necromancer, Barbarian, Paladin, Sorceress, Druid}        
        public string name;
        public PlayerClass playerClass;
        public int maxHealth;
        public int currentHealth;
        public int maxMana;
        public int currentMana;
        public int str;
        public int dex;
        public int vit;
        public int magic;
        public int level;
        public int experience;
        public int fireResist;
        public int coldResist;
        public int lightResist;
        public int poisonResist;
        public Item currentWeapon;


        public Player(string Name, PlayerClass chosenClass)
        {
            playerClass = chosenClass;
            name = Name;
            // later on stats will be based on class chosen
            level = 1;
            experience = 0;
            maxHealth = 20;
            currentHealth = maxHealth;
            maxMana = 20;
            currentMana = maxMana;
            str = 15;
            dex = 15;
            vit = 15;
            magic = 15;

            currentWeapon = ItemFactory.CreateItem(1001);
        }
    }
}
