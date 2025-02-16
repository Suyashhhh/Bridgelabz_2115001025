using System;
using System.Text;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        int n = 10000;
        Stopwatch sw = new Stopwatch();

        sw.Start();
        string s = "";
        for (int i = 0; i < n; i++)
            s += "a";
        sw.Stop();
        Console.WriteLine("string: " + sw.ElapsedMilliseconds + " ms");

        sw.Restart();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
            sb.Append("a");
        sw.Stop();
        Console.WriteLine("StringBuilder: " + sw.ElapsedMilliseconds + " ms");
    }
}
