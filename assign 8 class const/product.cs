using System;
class Product
{
    public string productName;
    public double price;
    public static int totalProducts = 0;

    public Product(string productName, double price)
    {
        this.productName = productName;
        this.price = price;
        totalProducts++;
    }

    public void DisplayProductDetails()
    {
        Console.WriteLine($"product name: {productName}, price: {price}");
    }

    public static void DisplayTotalProducts()
    {
        Console.WriteLine($"total products: {totalProducts}");
    }

    static void Main()
    {
        Product p1 = new Product("laptop", 1200);
        p1.DisplayProductDetails();
        Product.DisplayTotalProducts();
    }
}
