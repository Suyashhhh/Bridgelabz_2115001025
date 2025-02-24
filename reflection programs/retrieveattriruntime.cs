using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class)]
public class AuthorAttribute : Attribute
{
    public string Name { get; }
    public AuthorAttribute(string name)
    {
        Name = name;
    }
}

[Author("Rajesh Kumar")]
public class Book
{
    public void Display() => Console.WriteLine("this is a book class");
}

class Program
{
    static void Main(string[] args)
    {
        Type type = typeof(Book);
        var attribute = (AuthorAttribute)Attribute.GetCustomAttribute(type, typeof(AuthorAttribute));

        if (attribute != null)
        {
            Console.WriteLine($"author: {attribute.Name}");
        }
        else
        {
            Console.WriteLine("no author attribute found");
        }
    }
}
