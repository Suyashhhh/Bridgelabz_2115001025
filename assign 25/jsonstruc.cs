using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

class Program
{
    static void Main()
    {
        string json = @"{ 'name': 'Asha', 'age': 22 }";
        string schemaJson = @"{ 'type': 'object', 'properties': { 'name': {'type': 'string'}, 'age': {'type': 'integer'} }, 'required': ['name', 'age'] }";

        JObject obj = JObject.Parse(json);
        JSchema schema = JSchema.Parse(schemaJson);

        bool isValid = obj.IsValid(schema, out var errors);
        Console.WriteLine(isValid ? "Valid JSON" : "Invalid JSON");
    }
}
