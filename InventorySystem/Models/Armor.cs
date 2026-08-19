using System;
using System.Collections.Generic;
using System.Text;

namespace InventorySystem.Models
{
    internal class Armor : Item
    {
        //Armor genel bilgileri tutulacak
        private int defenseValue;

        public int DefenseValue
        {
            get { return defenseValue; }
            set { defenseValue = value; }
        }

        public Armor(int id, string name, int price, int weight, int defenseValue) : base(id, name, price, weight)
        {
            DefenseValue = defenseValue;
        }
        public override void Detail()
        {
            Console.WriteLine($"Defensive Amount: {defenseValue}");
        }

    }

}
