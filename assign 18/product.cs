using System;
using System.Collections.Generic;

public abstract class ProductCategory
{
    public string Name { get; }
    protected ProductCategory(string name) { Name = name; }
    public override string ToString() => Name;
}

public class BookCategory : ProductCategory
{
    public BookCategory() : base("books") { }
}

public class ClothingCategory : ProductCategory
{
    public ClothingCategory() : base("clothing") { }
}

public class Product<T> where T : ProductCategory
{
    public string Name { get; }
    public double Price { get; private set; }
    public T Category { get; }

    public Product(string name, double price, T category)
    {
        Name = name;
        Price = price;
        Category = category;
    }

    public void ApplyDiscount(double percentage) => Price -= Price * (percentage / 100);
    public override string ToString() => $"{Name} - ${Price} ({Category})";
}

public class Marketplace
{
    private readonly List<object> catalog = new List<object>();

    public void AddProduct<T>(Product<T> product) where T : ProductCategory => catalog.Add(product);
    public void DisplayCatalog() => catalog.ForEach(product => Console.Write(product + " "));
}

class Program
{
    static void Main()
    {
        var marketplace = new Marketplace();

        var book = new Product<BookCategory>("c# fundamentals", 50, new BookCategory());
        var shirt = new Product<ClothingCategory>("formal shirt", 30, new ClothingCategory());

        marketplace.AddProduct(book);
        marketplace.AddProduct(shirt);

        book.ApplyDiscount(10);
        shirt.ApplyDiscount(20);

        Console.Write("catalog: "); marketplace.DisplayCatalog();
    }
}
