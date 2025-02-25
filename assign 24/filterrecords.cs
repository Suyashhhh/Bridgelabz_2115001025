using System;
using System.IO;

class StudentFilter
{
    public void FilterHighScorers(string filePath)
    {
        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("file not found.");
                return;
            }

            var lines = File.ReadAllLines(filePath);
            Console.WriteLine("students with marks > 80:");
            for (int i = 1; i < lines.Length; i++)
            {
                var fields = lines[i].Split(',');
                if (int.Parse(fields[3]) > 80)
                {
                    Console.WriteLine($"ID: {fields[0]}, Name: {fields[1]}, Marks: {fields[3]}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"error: {ex.Message}");
        }
    }

    static void Main()
    {
        var filter = new StudentFilter();
        filter.FilterHighScorers("students.csv");
    }
}
