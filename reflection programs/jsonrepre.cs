using System;
using System.Reflection;
using System.Text;

public class JsonConverter
{
    public static string ToJson(object obj)
    {
        Type type = obj.GetType();
        FieldInfo[] fields = type.GetFields();
        StringBuilder jsonBuilder = new StringBuilder();
        jsonBuilder.Append("{");

        for (int i = 0; i < fields.Length; i++)
        {
            var field = fields[i];
            string name = field.Name;
            string value = field.GetValue(obj)?.ToString() ?? "null";
            jsonBuilder.Append($"\"{name}\": \"{value}\"");

            if (i < fields.Length - 1)
            {
                jsonBuilder.Append(", ");
            }
        }

        jsonBuilder.Append("}");
        return jsonBuilder.ToString();
    }
}

public class Product
{
    public string Name;
    public double Price;
}

class Program
{
    static void Main(string[] args)
    {
        Product product = new Product { Name = "Laptop", Price = 999.99 };
        string json = JsonConverter.ToJson(product);
        Console.WriteLine(json);
    }
}
