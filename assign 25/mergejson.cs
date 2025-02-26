using System;
using Newtonsoft.Json.Linq;

class Program
{
    static void Main()
    {
        string json1 = @"{ 'name': 'Rahul', 'age': 27 }";
        string json2 = @"{ 'email': 'rahul@example.com', 'city': 'Mumbai' }";

        JObject obj1 = JObject.Parse(json1);
        JObject obj2 = JObject.Parse(json2);

        obj1.Merge(obj2);
        Console.WriteLine(obj1.ToString());
    }
}
