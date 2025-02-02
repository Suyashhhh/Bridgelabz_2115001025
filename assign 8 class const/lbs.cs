using System;
class Book
{
    public string title, author;
    public double price;
    public bool availability;

    public Book(string title, string author, double price, bool availability)
    {
        this.title = title;
        this.author = author;
        this.price = price;
        this.availability = availability;
    }

    public void BorrowBook()
    {
        if (availability)
        {
            availability = false;
            Console.WriteLine("book borrowed");
        }
        else
        {
            Console.WriteLine("book unavailable");
        }
    }

    static void Main()
    {
        Book book1 = new Book("secrets", "george", 599, true);
        book1.BorrowBook();
    }
}
