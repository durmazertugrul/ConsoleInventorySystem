using System;
using InventorySystem.Managers;

namespace  InventorySystem 
{ 
    class Program
        {
            static void Main(string[] args)
            {
                InventoryManager manager = new InventoryManager();
                manager.OpenInventory();

                Console.ReadKey();
            }
    }
}