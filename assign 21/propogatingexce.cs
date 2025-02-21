using System;

class ExceptionPropagationDemo
{
    public static void Method1()
    {
        int result = 10 / 0;
    }

    public static void Method2()
    {
        Method1();
    }

    public static void Main()
    {
        try
        {
            Method2();
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("handled exception in main");
        }
    }
}
