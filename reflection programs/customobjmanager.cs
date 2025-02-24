using System;
using System.Collections.Generic;
using System.Reflection;

public class ObjectMapper
{
    public static T ToObject<T>(Dictionary<string, object> properties) where T : new()
    {
        T obj = new T();
        Type type = typeof(T);

        foreach (var prop in properties)
        {
            FieldInfo field = type.GetField(prop.Key);
            if (field != null)
            {
                field.SetValue(obj, prop.Value);
            }
        }
        return obj;
    }
}

public class Person
{
    public string Name;
    public int Age;
}

class Program
{
    static void Main(string[] args)
    {
        var properties = new Dictionary<string, object>
        {
            { "Name", "Suresh" },
            { "Age", 30 }
        };

        Person person = ObjectMapper.ToObject<Person>(properties);
        Console.WriteLine($"name: {person.Name}, age: {person.Age}");
    }
}
