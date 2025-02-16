using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "file3.txt";

        using FileStream fs = new FileStream(path, FileMode.Open);
        using StreamReader sr = new StreamReader(fs);
        string content = sr.ReadToEnd();
        
        Console.WriteLine(content);
    }
}
