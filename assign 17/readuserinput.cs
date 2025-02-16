using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = "output.txt";
        Console.WriteLine("enter text (type 'stop' to stop):");

        using StreamWriter sw = new StreamWriter(path);
        string input;
        while ((input = Console.ReadLine()) != "stop")
            sw.WriteLine(input);

        Console.WriteLine("text saved to output.txt");
    }
}
