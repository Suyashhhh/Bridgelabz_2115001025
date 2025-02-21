using System;
using System.IO;

class FileReader
{
    public static void Main()
    {
        try
        {
            using (StreamReader reader = new StreamReader("info.txt"))
            {
                string firstLine = reader.ReadLine();
                if (firstLine != null)
                {
                    Console.WriteLine("first line: " + firstLine);
                }
                else
                {
                    Console.WriteLine("file is empty");
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("an error occurred while reading the file: " + ex.Message);
        }
    }
}
