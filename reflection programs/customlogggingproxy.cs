using System;
using System.Reflection;

public interface IGreeting
{
    void SayHello();
}

public class Greeting : IGreeting
{
    public void SayHello()
    {
        Console.WriteLine("hello there!");
    }
}

public class LoggingProxy : DispatchProxy
{
    private IGreeting target;

    protected override object Invoke(MethodInfo method, object[] args)
    {
        Console.WriteLine($"calling method: {method.Name}");
        return method.Invoke(target, args);
    }

    public static IGreeting Create(IGreeting target)
    {
        var proxy = Create<IGreeting, LoggingProxy>() as LoggingProxy;
        proxy.target = target;
        return proxy as IGreeting;
    }
}

class Program
{
    static void Main(string[] args)
    {
        IGreeting greeting = new Greeting();
        IGreeting proxy = LoggingProxy.Create(greeting);
        proxy.SayHello();
    }
}
