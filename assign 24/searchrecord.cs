using System;
using System.IO;

class EmployeeSearch
{
    public void SearchEmployee(string filePath, string name)
    {
        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("file not found.");
                return;
            }

            var lines = File.ReadAllLines(filePath);
            bool found = false;

            for (int i = 1; i < lines.Length; i++)
            {
                var fields = lines[i].Split(',');
                if (fields[1].Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Department: {fields[2]}, Salary: {fields[3]}");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("employee not found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"error: {ex.Message}");
        }
    }

    static void Main()
    {
        var search = new EmployeeSearch();
        search.SearchEmployee("employees.csv", "Chintu");
    }
}
