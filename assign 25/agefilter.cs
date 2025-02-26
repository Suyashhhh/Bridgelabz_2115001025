using System;
using System.Linq;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        string json = @"[
            { 'name': 'Ankit', 'age': 30 },
            { 'name': 'Neha', 'age': 22 },
            { 'name': 'Ramesh', 'age': 27 }
        ]";

        JArray data = JArray.Parse(json);
        var filtered = data.Where(user => (int)user["age"] > 25);

        foreach (var user in filtered)
        {
            Console.WriteLine(user);
        }
    }
}
