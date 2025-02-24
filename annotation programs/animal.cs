using System;

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("animal makes a sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("dog barks");
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Animal dog = new Dog();
            dog.MakeSound();
        }
        catch (Exception ex)
        {
            Console.WriteLine("an error occurred: " + ex.Message);
        }
    }
}
