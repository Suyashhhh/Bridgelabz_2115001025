using System;
using System.IO;

public class StudentDataReader
{
    public void ReadAndPrintStudentData(string filePath)
    {
        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("file not found.");
                return;
            }

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var fields = line.Split(',');
                Console.WriteLine($"ID: {fields[0]}, Name: {fields[1]}, Age: {fields[2]}, Marks: {fields[3]}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"error: {ex.Message}");
        }
    }
}
