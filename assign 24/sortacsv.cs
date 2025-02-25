using System;
using System.IO;
using System.Linq;

class EmployeeSorter
{
    public void SortBySalary(string filePath)
    {
        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("file not found.");
                return;
            }

            var lines = File.ReadAllLines(filePath);
            var employees = lines.Skip(1)
                .Select(line => line.Split(','))
                .OrderByDescending(fields => double.Parse(fields[3]))
                .Take(5);

            Console.WriteLine("top 5 highest-paid employees:");
            foreach (var fields in employees)
            {
                Console.WriteLine($"Name: {fields[1]}, Salary: {fields[3]}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"error: {ex.Message}");
        }
    }

    static void Main()
    {
        var sorter = new EmployeeSorter();
        sorter.SortBySalary("employees.csv");
    }
}
