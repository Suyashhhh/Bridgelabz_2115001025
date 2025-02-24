using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class TodoAttribute : Attribute
{
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; }

    public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

class ProjectDevelopment
{
    [Todo("Implement login functionality", "Ramesh", "HIGH")]
    [Todo("Add forgot password feature", "Suresh")]
    public void AuthenticationModule()
    {
        Console.WriteLine("working on authentication module...");
    }

    [Todo("Optimize database queries", "Ganesh", "LOW")]
    public void DatabaseModule()
    {
        Console.WriteLine("working on database optimizations...");
    }

    public void CompletedModule()
    {
        Console.WriteLine("this module is completed.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            ProjectDevelopment project = new ProjectDevelopment();
            Type type = typeof(ProjectDevelopment);

            foreach (MethodInfo method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                var attributes = method.GetCustomAttributes(typeof(TodoAttribute), false);
                foreach (TodoAttribute attr in attributes)
                {
                    Console.WriteLine($"method: {method.Name}, task: {attr.Task}, assigned to: {attr.AssignedTo}, priority: {attr.Priority}");
                }

                method.Invoke(project, null);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("an error occurred: " + ex.Message);
        }
    }
}
