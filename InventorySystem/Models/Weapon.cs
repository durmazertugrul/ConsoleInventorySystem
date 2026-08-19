using System;
using System.Collections.Generic;
using System.Text;

namespace InventorySystem.Models
{
    internal class Weapon : Item
    {
        //Weapon genel bilgileri tutulacak
        private int damageValue;

        public int DamageValue
        {
            get { return damageValue; }
            set { damageValue = value; }
        }

        public Weapon(int id, string name, int price, int weight, int damageValue) : base(id, name, price, weight)
        {
            DamageValue = damageValue;
        }

        public override void Detail()
        {
            Console.WriteLine($"Damage Amount: {damageValue}");
        }
    }

}
