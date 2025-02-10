using System;
using System.Collections.Generic;

interface ITaxable
{
    double CalculateTax();
    string GetTaxDetails();
}

abstract class Product
{
    private int productId;
    private string name;
    private double price;

    protected Product(int id, string name, double price)
    {
        productId = id;
        this.name = name;
        this.price = price;
    }

    protected double GetPrice() => price;

    public abstract double CalculateDiscount();

    public double GetFinalPrice()
    {
        double discount = CalculateDiscount();
        double tax = this is ITaxable taxable ? taxable.CalculateTax() : 0;
        return price + tax - discount;
    }

    public void DisplayDetails()
    {
        double tax = this is ITaxable taxable ? taxable.CalculateTax() : 0;
        Console.WriteLine($"{productId}\t{name}\t{price}\t{tax}\t{CalculateDiscount()}\t{GetFinalPrice()}");
    }
}

class Electronics : Product, ITaxable
{
    public Electronics(int id, string name, double price) : base(id, name, price) { }

    public override double CalculateDiscount() => GetPrice() * 0.1;

    public double CalculateTax() => GetPrice() * 0.18;

    public string GetTaxDetails() => "18% GST";
}

class Clothing : Product, ITaxable
{
    public Clothing(int id, string name, double price) : base(id, name, price) { }

    public override double CalculateDiscount() => GetPrice() * 0.2;

    public double CalculateTax() => GetPrice() * 0.12;

    public string GetTaxDetails() => "12% GST";
}

class Groceries : Product
{
    public Groceries(int id, string name, double price) : base(id, name, price) { }

    public override double CalculateDiscount() => GetPrice() * 0.05;
}

class Program
{
    static void Main()
    {
        var products = new List<Product>
        {
            new Electronics(201, "Laptop", 50000),
            new Clothing(202, "T-Shirt", 800),
            new Groceries(203, "Rice", 1200),
            new Electronics(204, "Smartphone", 30000),
            new Clothing(205, "Jeans", 1500),
            new Groceries(206, "Milk", 50)
        };

        Console.WriteLine("ID\tName\tPrice\tTax\tDiscount\tFinal Price");
        products.ForEach(p => p.DisplayDetails());
    }
}
