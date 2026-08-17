using System.Xml.Linq;

class Inventory 
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

        Console.Write("Price: ");
        int price = Convert.ToInt32(Console.ReadLine());

        Console.Write("Weight: ");
        int weight = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case '1':
                Console.Write("Damage: ");
                int damage = Convert.ToInt32(Console.ReadLine());

                items.Add(new Weapon(id, name, price, weight, damage));
                break;

            case '2':
                Console.Write("Defense: ");
                int defense = Convert.ToInt32(Console.ReadLine());

                items.Add(new Armor(id, name, price, weight, defense));
                break;

            case '3':
                Console.Write("Heal Amount: ");
                int heal = Convert.ToInt32(Console.ReadLine());

                items.Add(new Potion(id, name, price, weight, heal));
                break;

            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }

    public void RemoveItem(Item item)
    {
        items.Remove(item);
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
        foreach (Item item in items) 
        {
            Console.WriteLine(item.Name);
        }
    }

    public void SortItem(Item item)
    {
        items.Sort();
        foreach (Item item2 in items) 
        {
            Console.WriteLine(item2.Name + ", ");
        }
    }

    public void ShowItemDetail()
    {
        foreach (Item item in items)
        {
            Console.WriteLine($"{item.Name}\nID:{item.ID}\nPrice:{item.Price}\nWeight:{item.Weight}\n");
            item.Detail();
        }
    }
}

class Item 
{ //Item genel bilgileri tutulacak
    private int id;
    private string name;
    private int price;
    private int weight;

    public int ID 
    {
        get { return id; }
        set {  id = value; }
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
//İşlemler, menüler, genel yönetimsel bilgiler burada olacak. 
class InventoryManager
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
                    // Remove işlemi
                    break;

                case '4':
                    // Search işlemi
                    break;

                case '5':
                    // Sort işlemi
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
            Console.WriteLine("================================");
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



            if (userChoice >= '1' && userChoice <= '7')
            {
                return userChoice;
            }

            Console.WriteLine("Invalid choice!");

        }

    }
}
class Weapon : Item
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

class Armor : Item
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

class Potion : Item
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


class Program
    {
        static void Main(string[] args)
        {
            InventoryManager manager = new InventoryManager();
            manager.OpenInventory();





            Console.ReadKey();
        }
}
