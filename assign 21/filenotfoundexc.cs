using System;
using System.IO;

class FileReader
{
    public void ReadFile(string filePath)
    {
        try
        {
            string content = File.ReadAllText(filePath);
            Console.WriteLine("file content:\n" + content);
        }
        catch (IOException)
        {
            Console.WriteLine("file not found");
        }
    }
}

class Program
{
    static void Main()
    {
        FileReader reader = new FileReader();
        reader.ReadFile("data.txt");
    }
}
