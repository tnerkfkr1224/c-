using System;
using System.Collections.Generic;
using SwinAdventure;


namespace SwinAdventure
{
    public class Inventory
    {
        private List<Item> _items;

        public Inventory()
        {
            _items = new List<Item>();
        }


        public bool HasItem(string id)
        {
            foreach (Item i in _items)
            {
                if (i.AreYou(id))
                {
                    return true;
                }
            }
            return false;
        }


        public void Put(Item itm)
        {
            _items.Add(itm);
        }

        public Item Take(string id)
        {
            var item = Fetch(id);
            _items.Remove(item);
            return item;
        }

        public Item Fetch(string id)
        {
            foreach (Item i in _items)
            {
                if (i.AreYou(id))
                    return i;
            }
            return null;
        }

        public string ItemList
        {
            get
            {
                string result = "";
                foreach (Item i in _items)
                {
                    result += (i.ShortDescription + "\n\t");
                }
                return result;
            }
        }
    }
}

