using System;
using System.Collections.Generic;
using System.Text;

namespace InventorySystem.Models
{
    internal class Item
    { //Item genel bilgileri tutulacak
        private int id;
        private string name;
        private int price;
        private int weight;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Item(int id, string name, int price, int weight)
        {
            ID = id;
            Name = name;
            Price = price;
            Weight = weight;

        }

        public virtual void Detail()
        {
            Console.WriteLine($"{Name}\nID:{ID}\nPrice:{Price}\nWeight:{Weight}\n");
        }


    }
}
