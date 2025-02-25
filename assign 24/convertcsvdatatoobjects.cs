using System;
using System.Collections.Generic;
using System.IO;

class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Marks { get; set; }

    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}, Age: {Age}, Marks: {Marks}";
    }
}

class CSVToObjectConverter
{
    public List<Student> ConvertToStudentList(string filePath)
    {
        var students = new List<Student>();
        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("file not found.");
                return students;
            }

            var lines = File.ReadAllLines(filePath);
            for (int i = 1; i < lines.Length; i++)
            {
                var fields = lines[i].Split(',');
                var student = new Student
                {
                    ID = int.Parse(fields[0]),
                    Name = fields[1],
                    Age = int.Parse(fields[2]),
                    Marks = double.Parse(fields[3])
                };
                students.Add(student);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"error: {ex.Message}");
        }

        return students;
    }

    static void Main()
    {
        var converter = new CSVToObjectConverter();
        var students = converter.ConvertToStudentList("students.csv");
        Console.WriteLine("students list:");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }
}
