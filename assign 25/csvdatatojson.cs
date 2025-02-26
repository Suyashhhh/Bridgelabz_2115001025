using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using CsvHelper;
using System.Globalization;

class Program
{
    static void Main()
    {
        using var reader = new StreamReader("data.csv");
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        var records = csv.GetRecords<dynamic>();

        string json = JsonConvert.SerializeObject(records, Formatting.Indented);
        Console.WriteLine(json);
    }
}
