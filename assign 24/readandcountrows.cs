using System;
using System.IO;

public class RecordCounter
{
    public int CountRecords(string filePath)
    {
        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("file not found.");
                return 0;
            }

            var lines = File.ReadAllLines(filePath);
            return lines.Length - 1;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"error: {ex.Message}");
            return 0;
        }
    }
}
