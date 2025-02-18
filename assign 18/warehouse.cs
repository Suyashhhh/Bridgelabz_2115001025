using System;
using System.Collections.Generic;

public abstract class WarehouseItem
{
    public string Name { get; }
    public double Price { get; }

    protected WarehouseItem(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString() => $"{Name} - ${Price}";
}

public class Electronics : WarehouseItem
{
    public Electronics(string name, double price) : base(name, price) { }
}

public class Groceries : WarehouseItem
{
    public Groceries(string name, double price) : base(name, price) { }
}

public class Furniture : WarehouseItem
{
    public Furniture(string name, double price) : base(name, price) { }
}

public class Storage<T> where T : WarehouseItem
{
    private readonly List<T> items = new List<T>();

    public void AddItem(T item) => items.Add(item);
    public IEnumerable<T> GetItems() => items; // Covariant return type

    public void DisplayItems()
    {
        foreach (var item in items)
            Console.WriteLine(item);
    }
}

class Program
{
    static void Main()
    {
        var electronicsStorage = new Storage<Electronics>();
        electronicsStorage.AddItem(new Electronics("Laptop", 1200));
        electronicsStorage.AddItem(new Electronics("Smartphone", 800));

        var groceryStorage = new Storage<Groceries>();
        groceryStorage.AddItem(new Groceries("Apple", 1.5));
        groceryStorage.AddItem(new Groceries("Milk", 2.0));

        var furnitureStorage = new Storage<Furniture>();
        furnitureStorage.AddItem(new Furniture("Chair", 150));
        furnitureStorage.AddItem(new Furniture("Table", 300));

        Console.WriteLine("Electronics:");
        electronicsStorage.DisplayItems();

        Console.WriteLine("Groceries:");
        groceryStorage.DisplayItems();

        Console.WriteLine("Furniture:");
        furnitureStorage.DisplayItems();
    }
}
