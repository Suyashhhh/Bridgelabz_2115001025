using System;

[AttributeUsage(AttributeTargets.Field)]
public class MaxLengthAttribute : Attribute
{
    public int Length { get; }

    public MaxLengthAttribute(int length)
    {
        Length = length;
    }
}

public class User
{
    [MaxLength(10)]
    public string Username;

    public User(string username)
    {
        if (username.Length > 10)
        {
            throw new ArgumentException("username exceeds the maximum allowed length of 10 characters");
        }

        Username = username;
    }

    public void Display()
    {
        Console.WriteLine($"username: {Username}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            User validUser = new User("Ramesh123");
            validUser.Display();

            User invalidUser = new User("VeryLongUsername123"); // This will throw an exception
            invalidUser.Display();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("validation error: " + ex.Message);
        }
    }
}
