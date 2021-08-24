using System;
using System.Collections.Generic;
using System.Text;

namespace DiabloLoD_ConsoleEdition.GameItems
{

    class Weapon : Item
    {
        public int minDamage;
        public int maxDamage;


        // by using the : base() we are able to pass the needed variables for the base (Item) class.
        public Weapon(int ItemTypeId, string Name, int Price, int MinDamage, int MaxDamage) : base(ItemTypeId, Name, Price)
        {
            // by using the :base() the itemTypeId, name, and price are already being set.
            minDamage = MinDamage;
            maxDamage = MaxDamage;
        }

        public new Weapon Clone()
        {
            return new Weapon(itemTypeID, name, price, minDamage, maxDamage);
        }

    }
}
