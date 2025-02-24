using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field)]
public class InjectAttribute : Attribute
{
}

public class Service
{
    public void Execute() => Console.WriteLine("service executed");
}

public class Consumer
{
    [Inject]
    public Service MyService;

    public void Run()
    {
        MyService.Execute();
    }
}

public class SimpleDIContainer
{
    public static void InjectDependencies(object obj)
    {
        Type type = obj.GetType();
        FieldInfo[] fields = type.GetFields();

        foreach (var field in fields)
        {
            if (Attribute.IsDefined(field, typeof(InjectAttribute)))
            {
                object dependency = Activator.CreateInstance(field.FieldType);
                field.SetValue(obj, dependency);
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Consumer consumer = new Consumer();
        SimpleDIContainer.InjectDependencies(consumer);
        consumer.Run();
    }
}
