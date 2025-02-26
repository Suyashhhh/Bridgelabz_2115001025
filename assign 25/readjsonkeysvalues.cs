using System;
using System.IO;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        string json = File.ReadAllText("data.json");
        JObject obj = JObject.Parse(json);

        foreach (var item in obj)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
