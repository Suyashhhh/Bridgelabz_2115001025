using System;
using System.IO;
using System.Collections.Generic;

class DuplicateDetector
{
    public void DetectDuplicates(string filePath)
    {
        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("file not found.");
                return;
            }

            var lines = File.ReadAllLines(filePath);
            var idSet = new HashSet<string>();
            var duplicates = new List<string>();

            for (int i = 1; i < lines.Length; i++)
            {
                var fields = lines[i].Split(',');
                if (!idSet.Add(fields[0]))
                {
                    duplicates.Add(lines[i]);
                }
            }

            if (duplicates.Count > 0)
            {
                Console.WriteLine("duplicate records found:");
                foreach (var dup in duplicates)
                {
                    Console.WriteLine(dup);
                }
            }
            else
            {
                Console.WriteLine("no duplicates found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"error: {ex.Message}");
        }
    }

    static void Main()
    {
        var detector = new DuplicateDetector();
        detector.DetectDuplicates("students.csv");
    }
}
