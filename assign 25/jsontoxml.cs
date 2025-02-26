using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        string json = @"{ 'name': 'Pooja', 'age': 26, 'email': 'pooja@example.com' }";
        JObject obj = JObject.Parse(json);

        XDocument xml = JsonConvert.DeserializeXNode(obj.ToString(), "Root");
        Console.WriteLine(xml);
    }
}
