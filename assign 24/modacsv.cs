using System;
using System.IO;

class SalaryUpdater
{
    public void UpdateITDepartmentSalary(string inputPath, string outputPath)
    {
        try
        {
            if (!File.Exists(inputPath))
            {
                Console.WriteLine("input file not found.");
                return;
            }

            var lines = File.ReadAllLines(inputPath);
            for (int i = 1; i < lines.Length; i++)
            {
                var fields = lines[i].Split(',');
                if (fields[2].Equals("IT", StringComparison.OrdinalIgnoreCase))
                {
                    double salary = double.Parse(fields[3]);
                    salary += salary * 0.10;
                    fields[3] = Math.Round(salary, 2).ToString();
                    lines[i] = string.Join(",", fields);
                }
            }

            File.WriteAllLines(outputPath, lines);
            Console.WriteLine("salaries updated successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"error: {ex.Message}");
        }
    }

    static void Main()
    {
        var updater = new SalaryUpdater();
        updater.UpdateITDepartmentSalary("employees.csv", "updated_employees.csv");
    }
}
