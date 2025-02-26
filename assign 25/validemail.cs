using System;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

class Program
{
    static void Main()
    {
        string json = @"{ 'name': 'Vikas', 'email': 'vikas@example.com' }";
        string schemaJson = @"{
            'type': 'object',
            'properties': {
                'name': { 'type': 'string' },
                'email': { 'type': 'string', 'format': 'email' }
            },
            'required': ['name', 'email']
        }";

        JObject obj = JObject.Parse(json);
        JSchema schema = JSchema.Parse(schemaJson);

        bool isValid = obj.IsValid(schema, out var errors);
        Console.WriteLine(isValid ? "Valid JSON" : "Invalid JSON");
    }
}
