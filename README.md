# Console Inventory System

A simple console-based inventory management system, being developed to practice C# and OOP concepts.

## Status

🚧 v1 — actively in development. The project is being improved daily, one small step at a time.

## Purpose

The goal is to reinforce class design, inheritance, and basic CRUD logic (adding, removing, searching, sorting) through a console application.

## Planned Features

- [ ] List inventory (Show Inventory)
- [ ] Add item (Add Item)
- [ ] Remove item (Remove Item)
- [ ] Use item (Use Item)
- [ ] Search item (Search Item)
- [ ] Sort inventory (Sort Inventory)
- [ ] Show item details (Show Item Details)

## Project Structure

```
Inventory        -> Manages the item list and general inventory operations
Item             -> Base item class (id, name, price, weight)
Weapon : Item    -> Weapon (damage value)
Armor : Item     -> Armor (defense value)
Potion : Item    -> Potion (heal amount)
InventoryManager -> Menu and user interaction
Program          -> Entry point
```

## Technologies Used

- C#
- .NET (Console Application)

## Running the Project

```bash
dotnet run
```

## Notes

As development progresses, class relationships, method implementations, and menu logic will be added over time. Commit history is intentionally kept frequent and small to track how the project evolves step by step.
