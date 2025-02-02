using System;
class Book
{
    public string ISBN;
    protected string title;
    private string author;

    public void SetAuthor(string authorName)
    {
        author = authorName;
    }

    public string AuthorName // public property to get author directly
    {
        get { return author; }
    }
}

class EBook : Book
{
    public void DisplayISBNTitle()
    {
        Console.WriteLine($"ISBN: {ISBN}, Title: {title}");
    }

    static void Main()
    {
        EBook eBook = new EBook();
        eBook.ISBN = "112233";
        eBook.SetAuthor("Johnny cage ");
        eBook.DisplayISBNTitle();
        Console.WriteLine($"Author: {eBook.AuthorName}"); // using property to access author
    }
}
