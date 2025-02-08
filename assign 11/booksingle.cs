using System;
// Base class representing a Book
public class Book
{
public string Title { get; set; }
public int PublicationYear { get; set; }
public Book(string title, int publicationYear)
{
Title = title;
PublicationYear = publicationYear;
}
// Virtual method to be overridden by subclasses
public virtual void DisplayInfo()
{
Console.WriteLine("Title: {0}, Publication Year: {1}", Title,
PublicationYear);
}
}
// Subclass Author
public class Author : Book
{
public string Name { get; set; }
public string Bio { get; set; }
public Author(string title, int publicationYear, string name, string
bio) : base(title, publicationYear)
{
Name = name;
Bio = bio;
}
public override void DisplayInfo()
{
Console.WriteLine("Title: {0}, Publication Year: {1}, Author: {2},
Bio: {3}", Title, PublicationYear, Name, Bio);
}
}
// Main Program
public class Program
{
public static void Main()
{
Author book = new Author("The Great Gatsby", 1925, "F. Scott
Fitzgerald", "American novelist and short story writer.");
book.DisplayInfo();
}
}