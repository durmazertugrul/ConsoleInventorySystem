using System;
using System.Collections.Generic;
using System.Text;
using InventorySystem.Models;
using System.Globalization; //boşluk içeren stringlerin ilk harflerini büyük harf yapan kütüphane

namespace InventorySystem.Core
{
    internal class Inventory
    {
        //Envanter yapısının genel metotları yönetilecek. show, add, remove, use, search, sort, 
        List<Item> items = new List<Item>();

        public void AddExistingItem(Item item)//default bulunacak itemler
        {
            items.Add(item);
        }
        public void AddItem()
        {
            Console.WriteLine("1. Weapon");
            Console.WriteLine("2. Armor");
            Console.WriteLine("3. Potion");

            Console.Write("Choice: ");
            char choice = Convert.ToChar(Console.ReadLine());

            Console.Write("ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            TextInfo englishTextInfo = new CultureInfo("en-US").TextInfo;//ingilizce kültürüne dönüştürme
            string camelCaseName = englishTextInfo.ToTitleCase(name);//girilen stringin baş harflerini büyütür


            Console.Write("Price: ");
            int price = Convert.ToInt32(Console.ReadLine());

            Console.Write("Weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case '1':
                    Console.Write("Damage: ");
                    int damage = Convert.ToInt32(Console.ReadLine());

                    items.Add(new Weapon(id, camelCaseName, price, weight, damage));
                    break;

                case '2':
                    Console.Write("Defense: ");
                    int defense = Convert.ToInt32(Console.ReadLine());

                    items.Add(new Armor(id, camelCaseName, price, weight, defense));
                    break;

                case '3':
                    Console.Write("Heal Amount: ");
                    int heal = Convert.ToInt32(Console.ReadLine());

                    items.Add(new Potion(id, camelCaseName, price, weight, heal));
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }

        public void RemoveItem(int index) //RemoveMenu'den gelen indexi siler
        {

            if (index >= 0 && index < items.Count)
            {
                ColoredPrint($"{items[index].Name} has removed!", ConsoleColor.Red);
                items.RemoveAt(index);
                Console.WriteLine();
            }
            else { Console.WriteLine("Invalid index number!"); }
            Console.WriteLine();
        }

        public int RemoveMenu() //silinmek istenen item indexi seçilir 
        {
            int count = 1;
            foreach (var name in items) 
            {
                Console.WriteLine($"{count}- {name.Name}");
                count++;
            }

            Console.Write("Choose to remove: ");
            int removeIndex = int.Parse(Console.ReadLine());

            
            return removeIndex-1; //listedeki veriler sıfırdan başlaması dolayısıyla bir çıkarıyoruz sayma sayısına odaklamak için
        }



        //public void FindItem(Item item)
        //{

        //    if (items.Contains(i))
        //    {
        //        Console.WriteLine(item);
        //    }
        //    else { Console.WriteLine($"Such an {item} does not exist."); }
        //}


        public void ShowInventory()
        {
            ColoredPrint("\n================ INVENTORY ================", ConsoleColor.Green);    
            Console.WriteLine();

            foreach (Item item in items)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine();
        }

        public void SortItem() //item sıralama
        {
            Console.Write("1- Name\n2- ID\n3- Price\n4- Weight\nChoose(1/2/3/4): ");
            char choice = Convert.ToChar(Console.ReadLine());

            if (choice == '1')
            {
                var sortedBy = items.OrderBy(item => item.Name);

                foreach (var thing in sortedBy) 
                {
                    Console.WriteLine($"Name: {thing.Name}\nID: {thing.ID}\nPrice: {thing.Price}\nWeight: {thing.Weight}\n");
                }

            }

            else if (choice == '2')
            {
                var sortedBy = items.OrderBy(item => item.ID);

                foreach (var thing in sortedBy)
                {
                    Console.WriteLine($"Name: {thing.Name}\nID: {thing.ID}\nPrice: {thing.Price}\nWeight: {thing.Weight}\n");
                }
            }
            else if (choice == '3') 
            {
                var sortedBy = items.OrderBy(item => item.Price);

                foreach (var thing in sortedBy)
                {
                    Console.WriteLine($"Name: {thing.Name}\nID: {thing.ID}\nPrice: {thing.Price}\nWeight: {thing.Weight}\n");
                }
            }
            else if (choice == '4') 
            {
                var sortedBy = items.OrderBy(item => item.Weight);

                foreach (var thing in sortedBy)
                {
                    Console.WriteLine($"Name: {thing.Name}\nID: {thing.ID}\nPrice: {thing.Price}\nWeight: {thing.Weight}\n");
                }
            }
            else { Console.WriteLine("Invalid choice!"); }
        }              


        public void ShowItemDetail()
        {
            foreach (Item item in items)
            {
                Console.WriteLine($"{item.Name}\nID:{item.ID}\nPrice:{item.Price}\nWeight:{item.Weight}\n");
                item.Detail();
            }
        }

        protected void ColoredPrint(string text, ConsoleColor color)//renkli textler 
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }
    }
}
