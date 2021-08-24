using System;
using System.Collections.Generic;
using System.Text;

namespace DiabloLoD_ConsoleEdition.GameItems
{
    public class Item
    {
        public int itemTypeID;
        public string name;
        public int price;

        public Item(int ItemTypeID, string Name, int Price)
        {
            itemTypeID = ItemTypeID;
            name = Name;
            price = Price;
        }

        public Item Clone()
        {
            return new Item(itemTypeID, name, price);
        }

    }
}
