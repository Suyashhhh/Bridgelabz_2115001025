using System;
using System.Reflection;
using System.Text;

[AttributeUsage(AttributeTargets.Field)]
public class JsonFieldAttribute : Attribute
{
    public string Name { get; }

    public JsonFieldAttribute(string name)
    {
        Name = name;
    }
}

public class User
{
    [JsonField("user_name")]
    public string Username;

    [JsonField("email_address")]
    public string Email;

    [JsonField("contact_number")]
    public string Phone;

    public User(string username, string email, string phone)
    {
        Username = username;
        Email = email;
        Phone = phone;
    }
}

public class JsonSerializer
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
            var attribute = (JsonFieldAttribute)Attribute.GetCustomAttribute(field, typeof(JsonFieldAttribute));

            if (attribute != null)
            {
                string jsonKey = attribute.Name;
                string value = field.GetValue(obj)?.ToString() ?? "null";
                jsonBuilder.Append($"\"{jsonKey}\": \"{value}\"");

                if (i < fields.Length - 1)
                {
                    jsonBuilder.Append(", ");
                }
            }
        }

        jsonBuilder.Append("}");
        return jsonBuilder.ToString();
    }
}

class Program
{
    static void Main(string[] args)
    {
        User user = new User("Ramesh123", "ramesh@example.com", "9876543210");
        string json = JsonSerializer.ToJson(user);
        Console.WriteLine(json);
    }
}
