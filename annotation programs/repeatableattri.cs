using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class BugReportAttribute : Attribute
{
    public string Description { get; }

    public BugReportAttribute(string description)
    {
        Description = description;
    }
}

class BugTracker
{
    [BugReport("Null reference exception on line 25")]
    [BugReport("Incorrect output when input is negative")]
    public void ProcessData()
    {
        Console.WriteLine("processing data...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            BugTracker tracker = new BugTracker();
            Type type = typeof(BugTracker);

            foreach (MethodInfo method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                var attributes = method.GetCustomAttributes(typeof(BugReportAttribute), false);
                foreach (BugReportAttribute attr in attributes)
                {
                    Console.WriteLine($"method: {method.Name}, bug description: {attr.Description}");
                }

                method.Invoke(tracker, null);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("an error occurred: " + ex.Message);
        }
    }
}
