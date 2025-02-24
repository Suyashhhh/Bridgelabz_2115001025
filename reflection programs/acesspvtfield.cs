using System;
using System.Reflection;

public class Person
{
    private int age = 25;
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        Type type = typeof(Person);

        FieldInfo field = type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);

        if (field != null)
        {
            field.SetValue(person, 30);
            int newAge = (int)field.GetValue(person);
            Console.WriteLine($"updated age: {newAge}");
        }
        else
        {
            Console.WriteLine("field not found.");
        }
    }
}
