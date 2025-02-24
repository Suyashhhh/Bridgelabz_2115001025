using System;
using System.Reflection;

public class SampleClass
{
    public int number;
    private string text;

    public SampleClass() { }
    public void Display() { }
    private void HiddenMethod() { }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the class name:");
        string className = Console.ReadLine();

        Type type = Type.GetType(className);

        if (type != null)
        {
            Console.WriteLine($"class: {type.Name}");

            Console.WriteLine("methods:");
            MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var method in methods)
            {
                Console.WriteLine(method.Name);
            }

            Console.WriteLine("fields:");
            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var field in fields)
            {
                Console.WriteLine(field.Name);
            }

            Console.WriteLine("constructors:");
            ConstructorInfo[] constructors = type.GetConstructors();
            foreach (var constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
        }
        else
        {
            Console.WriteLine("class not found.");
        }
    }
}
