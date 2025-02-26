using System;
using System.IO;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        string json = File.ReadAllText("data.json");
        JArray data = JArray.Parse(json);

        foreach (var item in data)
        {
            Console.WriteLine($"name: {item["name"]}, email: {item["email"]}");
        }
    }
}
