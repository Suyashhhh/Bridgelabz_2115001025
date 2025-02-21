using System;

class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message) { }
}

class AgeValidator
{
    public void ValidateAge(int age)
    {
        if (age < 18)
        {
            throw new InvalidAgeException("age must be 18 or above");
        }
        Console.WriteLine("access granted!");
    }
}

class Program
{
    static void Main()
    {
        AgeValidator validator = new AgeValidator();
        try
        {
            Console.WriteLine("enter your age:");
            int age = int.Parse(Console.ReadLine());
            validator.ValidateAge(age);
        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("invalid input, please enter a numeric value");
        }
    }
}
