using System;
using System.Diagnostics;
using System.Text;

class Program
{
    static void Main()
    {
        int[] sizes = { 1000, 10000, 1000000 };

        foreach (int size in sizes)
        {
            Console.WriteLine($"\noperations: {size}");

            Stopwatch sw = new Stopwatch();

            sw.Start();
            StringConcatenation(size);
            sw.Stop();
            Console.WriteLine($"string concatenation: {sw.Elapsed.TotalMilliseconds} ms");

            sw.Restart();
            StringBuilderConcatenation(size);
            sw.Stop();
            Console.WriteLine($"stringbuilder concatenation: {sw.Elapsed.TotalMilliseconds} ms");
        }
    }

    static void StringConcatenation(int count)
    {
        string result = "";
        for (int i = 0; i < count; i++)
            result += "a";
    }

    static void StringBuilderConcatenation(int count)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < count; i++)
            sb.Append("a");
    }
}
