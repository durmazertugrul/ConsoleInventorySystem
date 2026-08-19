using System;
using System.Collections.Generic;
using System.Text;

namespace InventorySystem.Models
{
    internal class Potion : Item
    {
        //Potion genel bilgileri tutulacak

        private int healAmount;

        public int HealAmount
        {
            get { return healAmount; }
            set { healAmount = value; }
        }

        public Potion(int id, string name, int price, int weight, int healAmount) : base(id, name, price, weight)
        {
            HealAmount = healAmount;
        }

        public override void Detail()
        {
            Console.WriteLine($"Heal Amount: {healAmount}");
        }
    }
}
