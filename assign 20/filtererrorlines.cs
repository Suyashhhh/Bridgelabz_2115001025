using System;
using System.IO;

class LargeFileReader
{
    static void Main()
    {
        string filePath = "largefile.txt";

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("file not found.");
        }
        catch (IOException e)
        {
            Console.WriteLine("io error: " + e.Message);
        }
    }
}
