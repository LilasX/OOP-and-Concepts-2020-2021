using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Classes
{
    public class Item
    {
        string name;
        int price;

        public Item(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public Item()
        {
            this.name = null;
            this.price = 0;
        }

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
    }
}
