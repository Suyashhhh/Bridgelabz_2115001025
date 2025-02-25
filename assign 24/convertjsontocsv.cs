using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

class JSONCSVConverter
{
    public void ConvertJsonToCsv(string jsonFilePath, string csvFilePath)
    {
        try
        {
            var jsonData = File.ReadAllText(jsonFilePath);
            var students = JsonConvert.DeserializeObject<List<Student>>(jsonData);

            using (StreamWriter writer = new StreamWriter(csvFilePath))
            {
                writer.WriteLine("ID,Name,Age");
                foreach (var student in students)
                {
                    writer.WriteLine($"{student.ID},{student.Name},{student.Age}");
                }
            }

            Console.WriteLine("json converted to csv successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"error: {ex.Message}");
        }
    }

    public void ConvertCsvToJson(string csvFilePath, string jsonFilePath)
    {
        try
        {
            var lines = File.ReadAllLines(csvFilePath);
            var students = new List<Student>();

            for (int i = 1; i < lines.Length; i++)
            {
                var fields = lines[i].Split(',');
                students.Add(new Student
                {
                    ID = int.Parse(fields[0]),
                    Name = fields[1],
                    Age = int.Parse(fields[2])
                });
            }

            var jsonData = JsonConvert.SerializeObject(students, Formatting.Indented);
            File.WriteAllText(jsonFilePath, jsonData);

            Console.WriteLine("csv converted to json successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"error: {ex.Message}");
        }
    }

    static void Main()
    {
        var converter = new JSONCSVConverter();
        converter.ConvertJsonToCsv("students.json", "students.csv");
        converter.ConvertCsvToJson("students.csv", "students_converted.json");
    }

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
