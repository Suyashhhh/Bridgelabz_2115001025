using System;
using System.Diagnostics;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string filePath = "file.txt";
        GenerateLargeFile(filePath, 500 * 1024 * 1024);

        Console.WriteLine("reading 500MB file:");

        Stopwatch sw = new Stopwatch();

        sw.Start();
        ReadWithStreamReader(filePath);
        sw.Stop();
        Console.WriteLine($"streamreader: {sw.Elapsed.TotalSeconds} s");

        sw.Restart();
        ReadWithFileStream(filePath);
        sw.Stop();
        Console.WriteLine($"filestream: {sw.Elapsed.TotalSeconds} s");
    }

    static void GenerateLargeFile(string filePath, int size)
    {
        using FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
        byte[] data = Encoding.UTF8.GetBytes(new string('A', 1024));
        for (int i = 0; i < size / 1024; i++) fs.Write(data, 0, data.Length);
    }

    static void ReadWithStreamReader(string filePath)
    {
        using StreamReader sr = new StreamReader(filePath);
        while (sr.Read() != -1) { }
    }

    static void ReadWithFileStream(string filePath)
    {
        using FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
        byte[] buffer = new byte[8192];
        while (fs.Read(buffer, 0, buffer.Length) > 0) { }
    }
}
