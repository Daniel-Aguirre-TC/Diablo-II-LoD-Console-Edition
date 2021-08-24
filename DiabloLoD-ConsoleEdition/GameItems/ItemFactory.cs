using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DiabloLoD_ConsoleEdition.GameItems
{
    public static class ItemFactory
    {
        
        // static class because we won't instantiate it, we are just going to use the functions to create Items
        private static List<Item> standardGameItems;

        // the first time anyone uses the ItemFactory instance, the ItemFactory constructor will be called below.
        static ItemFactory()
        {
            standardGameItems = new List<Item>();
            standardGameItems.Add(new Weapon(1001, "Short Sword", 20, 2, 7));
            standardGameItems.Add(new Weapon(1002, "Scimitar", 25, 2, 6));
            standardGameItems.Add(new Weapon(1003, "Sword", 30, 3, 8));
        }


        public static Item CreateItem(int itemTypeID)
        {
            Item standardItem = standardGameItems.FirstOrDefault(item => item.itemTypeID == itemTypeID);

            if (standardItem != null)
            {
                return standardItem.Clone();
            }
            // if no item exists for the provided itemTypeID, return null;
            return null;
        }
    }
}
