using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method)]
public class TaskInfoAttribute : Attribute
{
    public int Priority { get; }
    public string AssignedTo { get; }

    public TaskInfoAttribute(int priority, string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}

class TaskManager
{
    [TaskInfo(1, "Rajesh")]
    public void CompleteReport()
    {
        Console.WriteLine("report task completed");
    }

    [TaskInfo(2, "Suresh")]
    public void FixBug()
    {
        Console.WriteLine("bug fixing completed");
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            TaskManager manager = new TaskManager();
            Type type = typeof(TaskManager);

            foreach (MethodInfo method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                var attributes = method.GetCustomAttributes(typeof(TaskInfoAttribute), false);
                foreach (TaskInfoAttribute attr in attributes)
                {
                    Console.WriteLine($"method: {method.Name}, priority: {attr.Priority}, assigned to: {attr.AssignedTo}");
                }

                method.Invoke(manager, null);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("an error occurred: " + ex.Message);
        }
    }
}
