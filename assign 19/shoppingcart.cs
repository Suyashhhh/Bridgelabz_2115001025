using System;
using System.Collections.Generic;

class ShoppingCart
{
    Dictionary<string, double> productPrices = new Dictionary<string, double>();
    LinkedList<(string, double)> orderedProducts = new LinkedList<(string, double)>();
    SortedDictionary<double, List<string>> sortedByPrice = new SortedDictionary<double, List<string>>();

    public void AddProduct(string product, double price)
    {
        if (!productPrices.ContainsKey(product))
        {
            productPrices[product] = price;
            orderedProducts.AddLast((product, price));

            if (!sortedByPrice.ContainsKey(price))
                sortedByPrice[price] = new List<string>();
            sortedByPrice[price].Add(product);
        }
    }

    public void DisplayCart()
    {
        Console.WriteLine("Shopping Cart:");
        foreach (var kvp in productPrices)
            Console.WriteLine($"{kvp.Key}: ${kvp.Value}");
    }

    public void DisplayOrder()
    {
        Console.WriteLine("\nOrder of Items Added:");
        foreach (var item in orderedProducts)
            Console.WriteLine($"{item.Item1}: ${item.Item2}");
    }

    public void DisplaySortedByPrice()
    {
        Console.WriteLine("\nItems Sorted by Price:");
        foreach (var kvp in sortedByPrice)
            foreach (var product in kvp.Value)
                Console.WriteLine($"{product}: ${kvp.Key}");
    }
}

class Program
{
    static void Main()
    {
        ShoppingCart cart = new ShoppingCart();

        cart.AddProduct("Laptop", 999.99);
        cart.AddProduct("Phone", 499.99);
        cart.AddProduct("Headphones", 149.99);
        cart.AddProduct("Mouse", 49.99);

        cart.DisplayCart();
        cart.DisplayOrder();
        cart.DisplaySortedByPrice();
    }
}
