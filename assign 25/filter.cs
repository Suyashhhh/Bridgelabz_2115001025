using System;
using System.Linq;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        string json = @"[
            { 'name': 'Vikas', 'age': 30 },
            { 'name': 'Priya', 'age': 22 },
            { 'name': 'Arjun', 'age': 27 }
        ]";

        JArray data = JArray.Parse(json);
        var filtered = data.Where(item => (int)item["age"] > 25);

        foreach (var person in filtered)
        {
            Console.WriteLine(person);
        }
    }
}
