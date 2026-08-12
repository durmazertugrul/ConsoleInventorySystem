class Inventory 
{ 
    //Envanter yapısının genel metotları yönetilecek. show, add, remove, use, search, sort, 
    List<Item> items = new List<Item>();

    public void AddItem() { }
    public void RemoveItem() { }
    public void FindItem() { }
    public void UseItem() { }
    public void ShowInventory() { }
    public void SortItem() { }
    public void ShowItemDetail() { }
}

class Item 
{ //Item genel bilgileri tutulacak
    private int id;
    private string name;
    private int prive;
    private float weight;


}

class InventoryManager 
{
    //İşlemler, menüler, genel yönetimsel bilgiler burada olacak. 

    public void MainMenu() 
    {
        /*
         * Genel görünüm:
            ================================
                    INVENTORY SYSTEM
            ================================

            1. Show Inventory
            2. Add Item
            3. Remove Item
            4. Use Item
            5. Search Item
            6. Sort Inventory
            7. Show Item Details
            8. Exit

            Select:
         */
    }
}

class Weapon : Item
{ 
    //Weapon genel bilgileri tutulacak
    private int damageValue;
}

class Armor : Item
{
    //Armor genel bilgileri tutulacak

    private int defenseValue;


}

class Potion : Item
{
    //Potion genel bilgileri tutulacak

    private int healAmount;
}


class Program 
{
    static void Main(string[] args)
    {
        





        Console.ReadKey();
    }
}