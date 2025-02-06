using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}");
    }
}

class Library
{
    public string Name { get; set; }
    private List<Book> books;

    public Library(string name)
    {
        Name = name;
        books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void DisplayBooks()
    {
        Console.WriteLine($"Books in {Name} Library:");
        foreach (var book in books)
        {
            book.DisplayInfo();
        }
    }
}

class Program
{
    static void Main()
    {
        // Create some Book objects
        Book book1 = new Book("1984", "George Orwell");
        Book book2 = new Book("Brave New World", "Aldous Huxley");
        Book book3 = new Book("Moby Dick", "Herman Melville");

        // Create Library objects
        Library library1 = new Library("City Library");
        Library library2 = new Library("University Library");

        // Add books to libraries
        library1.AddBook(book1);
        library1.AddBook(book2);
        library2.AddBook(book3);

        // Display books in each library
        library1.DisplayBooks();
        library2.DisplayBooks();
    }
}
