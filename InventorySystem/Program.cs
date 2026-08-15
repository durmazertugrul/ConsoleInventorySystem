using System.Xml.Linq;

class Inventory 
{ 
    //Envanter yapısının genel metotları yönetilecek. show, add, remove, use, search, sort, 
    List<Item> items = new List<Item>();

    public void AddItem(Item item) 
    { 
        items.Add(item);
    }

    public void RemoveItem(Item item)
    {
        items.Remove(item);
    }

    public void FindItem(Item item)
    {
        if (items.Contains(item)) 
        {
            Console.WriteLine(item);
        }
        else { Console.WriteLine($"Such an {item} does not exist."); }
    }

    public void UseItem()
    {

    }

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
            Console.WriteLine($"{item.Name}\nID:{item.ID}\nPrice:{item.Price}\nWeight:{item.Weight}");
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
        id = ID;
        name = Name;
        price = Price;
        weight = Weight;
    
    }

    public virtual void Detail() 
    {
        Console.WriteLine($"{Name}\nID:{ID}\nPrice:{Price}\nWeight:{Weight}");
    }


}

class InventoryManager 
{
    //İşlemler, menüler, genel yönetimsel bilgiler burada olacak. 


    public void OpenInventory() 
    {
        //tüm sistem buradan yönetilecek

        char mainMenuChoice = MainMenu();
        if (mainMenuChoice == 8) return;
        
        
    }

    public char MainMenu() 
    {        
        while (true) 
        {
            Console.WriteLine("================================");
            Console.WriteLine("     INVENTORY SYSTEM");
            Console.WriteLine("================================");
            Console.WriteLine("1. Show Inventory\r\n" +
                               "2. Add Item\r\n" +
                               "3. Remove Item\r\n" +
                               "4. Use Item\r\n" +
                               "5. Search Item\r\n" +
                               "6. Sort Inventory\r\n" +
                               "7. Show Item Details\r\n" +
                               "8. Exit");

            char userChoice = Convert.ToChar(Console.ReadLine());

            

            if (!char.IsWhiteSpace(userChoice)) 
            {
                switch (userChoice)
                {
                    case '1':
                        return '1';
                    case '2':
                        return '2';
                    case '3':
                        return '3';
                    case '4':
                        return '4';
                    case '5':
                        return '5';
                    case '6':
                        return '6';
                    case '7':
                        return '7';
                    case '9':
                        Console.Write("Exiting...");
                        return '8';
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
            else 
            {
                Console.WriteLine("Invalid input. Please enter a single character.\n");
            }

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

    public Weapon(int id = 101, string name = "weapon", int price = 100, int weight = 25, int damageValue = 50) : base(id, name, price, weight) 
    {
        DamageValue = damageValue;
    }

    public override void Detail()
    {
        base.Detail();
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

    public Armor(int id = 201, string name = "armor", int price = 80, int weight = 32, int defenseValue = 44) : base(id, name, price, weight)
    {
        DefenseValue = defenseValue;
    }
    public override void Detail()
    {
        base.Detail();
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

    public Potion(int id = 301, string name = "potion", int price = 30, int weight = 2, int HealAmount = 5) : base(id, name, price, weight)
    {
        HealAmount = healAmount;
    }

    public override void Detail()
    {
        base.Detail();
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