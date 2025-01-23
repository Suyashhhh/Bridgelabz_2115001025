
using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the employee's salary: ");
        double salary = double.Parse(Console.ReadLine());
        Console.Write("Enter the employee's years of service: ");
        int yearsOfService = int.Parse(Console.ReadLine());
        double bonus = yearsOfService > 5 ? salary * 0.05 : 0;
        Console.WriteLine($"The bonus amount is: {bonus}");
    }
}

