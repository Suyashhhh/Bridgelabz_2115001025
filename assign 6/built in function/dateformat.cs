using System;
class Program
{
    static void Main()
    {
        DateTime currentDate = DateTime.Now;

        Console.WriteLine(currentDate.ToString("dd/MM/yyyy"));
        Console.WriteLine(currentDate.ToString("yyyy-MM-dd"));
        Console.WriteLine(currentDate.ToString("EEE, MMM dd, yyyy"));
    }
}

