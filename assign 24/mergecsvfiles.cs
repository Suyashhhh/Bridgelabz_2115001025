using System;
using System.IO;
using System.Collections.Generic;

class CSVFileMerger
{
    public void MergeFiles(string file1Path, string file2Path, string outputPath)
    {
        try
        {
            if (!File.Exists(file1Path) || !File.Exists(file2Path))
            {
                Console.WriteLine("one or both files not found.");
                return;
            }

            var file1Lines = File.ReadAllLines(file1Path);
            var file2Lines = File.ReadAllLines(file2Path);
            var mergedData = new Dictionary<string, string>();

            for (int i = 1; i < file1Lines.Length; i++)
            {
                var fields = file1Lines[i].Split(',');
                mergedData[fields[0]] = $"{fields[0]},{fields[1]},{fields[2]}";
            }

            for (int i = 1; i < file2Lines.Length; i++)
            {
                var fields = file2Lines[i].Split(',');
                if (mergedData.ContainsKey(fields[0]))
                {
                    mergedData[fields[0]] += $",{fields[1]},{fields[2]}";
                }
            }

            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                writer.WriteLine("ID,Name,Age,Marks,Grade");
                foreach (var entry in mergedData)
                {
                    writer.WriteLine(entry.Value);
                }
            }

            Console.WriteLine("files merged successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"error: {ex.Message}");
        }
    }

    static void Main()
    {
        var merger = new CSVFileMerger();
        merger.MergeFiles("students1.csv", "students2.csv", "merged_students.csv");
    }
}
