using InventorySystem.Core;
using InventorySystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InventorySystem.Managers
{
    internal class InventoryManager
    {
        private Inventory inventory = new Inventory();
        public InventoryManager()//Default olarak üç tür bulunur
        {
            inventory.AddExistingItem(new Weapon(101, "Wooden Sword", 100, 25, 10));
            inventory.AddExistingItem(new Armor(201, "Iron Armor", 80, 32, 44));
            inventory.AddExistingItem(new Potion(301, "Health Potion", 30, 2, 5));
        }



        public void OpenInventory()
        {
            //tüm sistem buradan yönetilecek

            while (true)
            {
                char choice = MainMenu();

                switch (choice)
                {
                    case '1':
                        inventory.ShowInventory();
                        break;

                    case '2':
                        // Add işlemi

                        inventory.AddItem();
                        break;

                    case '3':
                        int index = inventory.RemoveMenu();
                        inventory.RemoveItem(index);
                        break;

                    case '4':
                        // Search işlemi
                        break;

                    case '5':
                        inventory.SortItem();
                        break;

                    case '6':
                        inventory.ShowItemDetail();
                        break;

                    case '7':
                        Console.WriteLine("Exiting...");
                        return;
                }
            }


        }


        public char MainMenu()
        {
            while (true)
            {
                Console.WriteLine("\n================================");
                Console.WriteLine("        INVENTORY SYSTEM");
                Console.WriteLine("================================");
                Console.WriteLine("1. Show Inventory\r\n" +
                                   "2. Add Item\r\n" +
                                   "3. Remove Item\r\n" +
                                   "4. Search Item\r\n" +
                                   "5. Sort Inventory\r\n" +
                                   "6. Show Item Details\r\n" +
                                   "7. Exit");
                Console.Write("\nChoice:");
                char userChoice = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();


                if (userChoice >= '1' && userChoice <= '7')
                {
                    return userChoice;
                }

                Console.WriteLine("Invalid choice!");

            }

        }
    }
}
