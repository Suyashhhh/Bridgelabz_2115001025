using System;
using System.Collections.Generic;

class ECommerce
{
    private string name;
    private List<Customer> customers = new List<Customer>();

    public ECommerce(string name)
    {
        this.name = name;
    }

    public void AddCustomer(Customer customer)
    {
        customers.Add(customer);
    }

    public void ShowDetails()
    {
        Console.WriteLine("e-commerce platform: " + name);
        Console.WriteLine("\ncustomers and their orders:");
        foreach (var customer in customers)
            customer.ShowOrders();
    }
}

class Customer
{
    private string name;
    private string customerID;
    private List<Order> orders = new List<Order>();

    public Customer(string name, string customerID)
    {
        this.name = name;
        this.customerID = customerID;
    }

    public void PlaceOrder(Order order)
    {
        orders.Add(order);
    }

    public void ShowOrders()
    {
        Console.WriteLine("\ncustomer: " + name + "\tid: " + customerID);
        foreach (var order in orders)
            order.ShowProducts();
    }

    public string GetName() { return name; }
}

class Order
{
    private string orderID;
    private List<Product> products = new List<Product>();

    public Order(string orderID)
    {
        this.orderID = orderID;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void ShowProducts()
    {
        Console.WriteLine("order id: " + orderID);
        foreach (var product in products)
            Console.WriteLine("product: " + product.GetName() + "\tprice: $" + product.GetPrice());
    }
}

class Product
{
    private string name;
    private double price;

    public Product(string name, double price)
    {
        this.name = name;
        this.price = price;
    }

    public string GetName() { return name; }
    public double GetPrice() { return price; }
}

class Program
{
    static void Main()
    {
        ECommerce amazon = new ECommerce("Amazon");

        Customer rajesh = new Customer("Rajesh", "C101");
        Customer munna = new Customer("Munna", "C102");

        Order order1 = new Order("O501");
        Order order2 = new Order("O502");

        Product laptop = new Product("Laptop", 750.50);
        Product phone = new Product("Smartphone", 299.99);
        Product headphones = new Product("Headphones", 49.99);
        Product book = new Product("Book", 19.99);

        order1.AddProduct(laptop);
        order1.AddProduct(phone);

        order2.AddProduct(headphones);
        order2.AddProduct(book);

        rajesh.PlaceOrder(order1);
        munna.PlaceOrder(order2);

        amazon.AddCustomer(rajesh);
        amazon.AddCustomer(munna);

        amazon.ShowDetails();
    }
}
