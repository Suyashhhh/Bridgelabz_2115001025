using System;
using System.IO;

class LargeCSVReader
{
    public void ReadInChunks(string filePath)
    {
        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("file not found.");
                return;
            }

            int recordCount = 0;
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    for (int i = 0; i < 100 && !reader.EndOfStream; i++)
                    {
                        reader.ReadLine();
                        recordCount++;
                    }
                    Console.WriteLine($"processed {recordCount} records so far...");
                }
            }

            Console.WriteLine($"total records processed: {recordCount}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"error: {ex.Message}");
        }
    }

    static void Main()
    {
        var reader = new LargeCSVReader();
        reader.ReadInChunks("largefile.csv");
    }
}
