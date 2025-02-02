using System;
class Book
{
    public string title, author;
    public double price;

    public Book() 
    { 
        title = "ello there"; //non parameterized default const.
        author = "general kenobi"; 
        price = 69.69; 
    }
    public Book(string title, string author, double price) 
    { 
        this.title = title; //parameterized const.
        this.author = author; 
        this.price = price; 
    }
    public void display() 
    { 
        Console.WriteLine($"title: {title} author: {author} price: {price}"); 
    }
	  static void Main()
    {
        Book book1 = new Book();
        book1.display();
        Console.WriteLine();
        Book book2 = new Book("jojos bizzare adventures", "Araki", 10.99);
        book2.display();
	}
}
