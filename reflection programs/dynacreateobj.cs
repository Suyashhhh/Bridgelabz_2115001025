using System;

public class Student
{
    public string Name { get; set; }

    public Student()
    {
        Name = "default student";
    }

    public void Display()
    {
        Console.WriteLine($"student name: {Name}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Type type = typeof(Student);

        object studentInstance = Activator.CreateInstance(type);

        if (studentInstance != null)
        {
            MethodInfo displayMethod = type.GetMethod("Display");
            displayMethod.Invoke(studentInstance, null);
        }
        else
        {
            Console.WriteLine("could not create instance.");
        }
    }
}
