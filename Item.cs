using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epic_Game
{
    class Item
    {      
        //Itemtypes:
        //0 - Weapons
        //1 - Helmets
        //2 - Chestplates
        string itemName;
        int itemPower;

        public Item(string itemName)
        {
            this.itemName = itemName;

            //Wooden Sword
            if (itemName == "Wooden Sword")
            {
                itemPower = 1;
            }

            //Claymore
            if (itemName == "Claymore")
            {
                itemPower = 4;
            }

            //Draconic Scimitar
            if (itemName == "Draconic Scimitar")
            {
                itemPower = 12;
            }
        }
         
        public string getItemName()
        {
            return itemName;
        }

        public int getItemPower()
        {
            return itemPower;
        }
    }
}
