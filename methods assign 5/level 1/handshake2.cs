
using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());
        int handshakes = CalculateHandshakes(numberOfStudents);
        Console.WriteLine($"The maximum number of handshakes among {numberOfStudents} students is {handshakes}");
    }
    static int CalculateHandshakes(int n)
    {
        return (n * (n - 1)) / 2;
    }
}

