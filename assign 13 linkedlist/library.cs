
using System;
class Book
{
    public string Title;
    public string Author;
    public string Genre;
    public int BookId;
    public bool IsAvailable;
    public Book Next;
    public Book Prev;

    public Book(string title, string author, string genre, int bookId, bool isAvailable)
    {
        Title = title;
        Author = author;
        Genre = genre;
        BookId = bookId;
        IsAvailable = isAvailable;
        Next = null;
        Prev = null;
    }
}

class Library
{
    public Book head;
    public Book tail;
    public int count = 0;

    public void AddAtBeginning(Book newBook)
    {
        if (head == null)
        {
            head = tail = newBook;
        }
        else
        {
            newBook.Next = head;
            head.Prev = newBook;
            head = newBook;
        }
        count++;
    }

    public void AddAtEnd(Book newBook)
    {
        if (head == null)
        {
            head = tail = newBook;
        }
        else
        {
            tail.Next = newBook;
            newBook.Prev = tail;
            tail = newBook;
        }
        count++;
    }

    public void AddAtPosition(Book newBook, int position)
    {
        if (position <= 1)
        {
            AddAtBeginning(newBook);
            return;
        }
        if (position > count)
        {
            AddAtEnd(newBook);
            return;
        }

        Book current = head;
        int i = 1;
        while (i < position - 1)
        {
            current = current.Next;
            i++;
        }

        newBook.Next = current.Next;
        newBook.Prev = current;
        current.Next.Prev = newBook;
        current.Next = newBook;
        count++;
    }

    public void RemoveByBookId(int bookId)
    {
        if (head == null) return;

        if (head.BookId == bookId)
        {
            head = head.Next;
            if (head != null) head.Prev = null;
            else tail = null;
            count--;
            return;
        }

        Book current = head;
        while (current != null && current.BookId != bookId)
        {
            current = current.Next;
        }

        if (current == null) return;

        if (current.Next != null) current.Next.Prev = current.Prev;
        if (current.Prev != null) current.Prev.Next = current.Next;
        if (current == tail) tail = current.Prev;

        count--;
    }

    public void SearchByTitleOrAuthor(string searchTerm)
    {
        Book current = head;
        bool found = false;
        while (current != null)
        {
            if (current.Title == searchTerm || current.Author == searchTerm)
            {
                Console.WriteLine(current.BookId + "\t" + current.Title + "\t" + current.Author + "\t" + current.Genre + "\t" + (current.IsAvailable ? "Available" : "Not Available"));
                found = true;
            }
            current = current.Next;
        }
        if (!found) Console.WriteLine("no books found");
    }

    public void UpdateAvailability(int bookId, bool isAvailable)
    {
        Book current = head;
        while (current != null)
        {
            if (current.BookId == bookId)
            {
                current.IsAvailable = isAvailable;
                return;
            }
            current = current.Next;
        }
    }

    public void DisplayAllForward()
    {
        Book current = head;
        while (current != null)
        {
            Console.WriteLine(current.BookId + "\t" + current.Title + "\t" + current.Author + "\t" + current.Genre + "\t" + (current.IsAvailable ? "Available" : "Not Available"));
            current = current.Next;
        }
    }

    public void DisplayAllReverse()
    {
        Book current = tail;
        while (current != null)
        {
            Console.WriteLine(current.BookId + "\t" + current.Title + "\t" + current.Author + "\t" + current.Genre + "\t" + (current.IsAvailable ? "Available" : "Not Available"));
            current = current.Prev;
        }
    }

    public int CountTotalBooks()
    {
        return count;
    }
}

class Program
{
    static void Main()
    {
        Library library = new Library();

        library.AddAtEnd(new Book("nosferatu", "f.w. murnau", "horror", 101, true));
        library.AddAtEnd(new Book("hereditary", "ari aster", "horror", 102, true));

        Console.WriteLine("all books (forward):");
        library.DisplayAllForward();
        Console.WriteLine();

        Console.WriteLine("all books (reverse):");
        library.DisplayAllReverse();
        Console.WriteLine();

        Console.WriteLine("total number of books:");
        Console.WriteLine(library.CountTotalBooks());
        Console.WriteLine();

        Console.WriteLine("searching for books by 'nosferatu' or 'ari aster':");
        library.SearchByTitleOrAuthor("nosferatu");
        library.SearchByTitleOrAuthor("ari aster");
        Console.WriteLine();

        Console.WriteLine("updating availability for book id 102:");
        library.UpdateAvailability(102, false);
        library.DisplayAllForward();
        Console.WriteLine();

        Console.WriteLine("removing book with book id 101:");
        library.RemoveByBookId(101);
        library.DisplayAllForward();
        Console.WriteLine();

        Console.WriteLine("adding a book at the beginning:");
        library.AddAtBeginning(new Book("the lighthouse", "robert eggers", "horror", 103, true));
        library.DisplayAllForward();
        Console.WriteLine();
    }
}

