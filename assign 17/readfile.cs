using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "file1.txt";

        using StreamReader sr = new StreamReader(path);
        string line;
        while ((line = sr.ReadLine()) != null)
            Console.WriteLine(line);
    }
}

