using System;
using System.Collections.Generic;

interface IDiscountable
{
    void ApplyDiscount(double discount);
    double GetDiscountDetails();
}

abstract class FoodItem : IDiscountable
{
    private string itemName;
    private double price;
    private int quantity;
    private double discount;

    protected FoodItem(string itemName, double price, int quantity)
    {
        this.itemName = itemName;
        this.price = price;
        this.quantity = quantity;
        this.discount = 0;
    }

    public abstract double CalculateTotalPrice();

    public void ApplyDiscount(double discount) => this.discount = discount;

    public double GetDiscountDetails() => discount;

    public void GetItemDetails()
    {
        Console.WriteLine($"{itemName}\t{quantity}\t{price}\t{CalculateTotalPrice() - discount}");
    }

    protected double GetBasePrice() => price * quantity;
}

class VegItem : FoodItem
{
    public VegItem(string itemName, double price, int quantity) : base(itemName, price, quantity) { }

    public override double CalculateTotalPrice() => GetBasePrice();
}

class NonVegItem : FoodItem
{
    private double extraCharge = 20;

    public NonVegItem(string itemName, double price, int quantity) : base(itemName, price, quantity) { }

    public override double CalculateTotalPrice() => GetBasePrice() + extraCharge;
}

class Program
{
    static void Main()
    {
        List<FoodItem> items = new List<FoodItem>
        {
            new VegItem("Paneer koftaaa", 150, 2),
            new NonVegItem("Chicken Biryani", 200, 1)
        };

        items[0].ApplyDiscount(10);
        
        Console.WriteLine("Item\tQty\tPrice\tFinal Price");
        items.ForEach(i => i.GetItemDetails());
    }
}

