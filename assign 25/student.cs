using System;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        var student = new
        {
            name = "Ramesh",
            age = 20,
            subjects = new string[] { "Math", "Physics", "Chemistry" }
        };

        string json = JsonConvert.SerializeObject(student, Formatting.Indented);
        Console.WriteLine(json);
    }
}
