using System;
class Product {
    static int Discount;
    private string ProductName {get; set;}
    readonly int ProductId;
    private int Price {get; set;}
    private int Quantity {get; set;}

    public Product(string productname, int id, int price, int quantity) {
        this.ProductName = productname;
        this.ProductId = id;
        this.Price = price;
        this.Quantity = quantity;
    }

    public static void UpdateDiscount(int discount) {
        Discount = discount;
    }

    public void DisplayDetails() {
        if (this is Product) {
            Console.WriteLine("product name is " + ProductName);
            Console.WriteLine("product ID: " + ProductId);
            Console.WriteLine("its price is: " + Price);
            Console.WriteLine("the discount for this product is: " + Discount + "%");
        }
    }
}

class Program {
    static void Main() {
        Product.UpdateDiscount(10);  
        Console.WriteLine("Initial discount: 10%");

        Product prod1 = new Product("lens cleaner", 135, 299, 1);
        prod1.DisplayDetails();

        Product.UpdateDiscount(50);
        Console.WriteLine("\nDiscount updated to 50%");

        Product prod2 = new Product("duster", 11, 69, 3);
        prod2.DisplayDetails();
    }
}