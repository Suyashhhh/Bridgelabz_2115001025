using System;
using System.Collections.Generic;

interface IReservable
{
    void ReserveItem(string borrower);
    bool CheckAvailability();
}

abstract class LibraryItem : IReservable
{
    private int itemId;
    private string title;
    private string author;
    private string borrower;

    protected LibraryItem(int itemId, string title, string author)
    {
        this.itemId = itemId;
        this.title = title;
        this.author = author;
        this.borrower = null;
    }

    public abstract int GetLoanDuration();

    public void ReserveItem(string borrower) => this.borrower = borrower;

    public bool CheckAvailability() => borrower == null;

    public void GetItemDetails()
    {
        Console.WriteLine($"{itemId}\t{title}\t{author}\t{(CheckAvailability() ? "Available" : "Reserved")}");
    }
}

class Book : LibraryItem
{
    public Book(int itemId, string title, string author) : base(itemId, title, author) { }
    public override int GetLoanDuration() => 14;
}

class Magazine : LibraryItem
{
    public Magazine(int itemId, string title, string author) : base(itemId, title, author) { }
    public override int GetLoanDuration() => 7;
}

class DVD : LibraryItem
{
    public DVD(int itemId, string title, string author) : base(itemId, title, author) { }
    public override int GetLoanDuration() => 3;
}

class Program
{
    static void Main()
    {
        List<LibraryItem> items = new List<LibraryItem>
        {
            new Book(101, "C# Fundamentals", "Rajesh Kumar"),
            new Magazine(102, "Tech World", "Amit Sharma"),
            new DVD(103, "The Matrix", "Lana Wachowski")
        };

        items[0].ReserveItem("Pintu");
        
        Console.WriteLine("ID\tTitle\tAuthor\tStatus");
        items.ForEach(i => i.GetItemDetails());
    }
}
