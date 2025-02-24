using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
public class ImportantMethodAttribute : Attribute
{
    public string Level { get; }

    public ImportantMethodAttribute(string level = "HIGH")
    {
        Level = level;
    }
}

class ProjectTasks
{
    [ImportantMethod("CRITICAL")]
    public void Deploy()
    {
        Console.WriteLine("deployment process started");
    }

    [ImportantMethod]
    public void Backup()
    {
        Console.WriteLine("backup completed successfully");
    }

    public void LogStatus()
    {
        Console.WriteLine("logging system status");
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            ProjectTasks tasks = new ProjectTasks();
            Type type = typeof(ProjectTasks);

            foreach (MethodInfo method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                var attributes = method.GetCustomAttributes(typeof(ImportantMethodAttribute), false);
                foreach (ImportantMethodAttribute attr in attributes)
                {
                    Console.WriteLine($"method: {method.Name}, importance level: {attr.Level}");
                }

                method.Invoke(tasks, null);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("an error occurred: " + ex.Message);
        }
    }
}
