using System;

class Program
{
    static double getinput(string prompt)
    {
        Console.Write(prompt);
        return double.Parse(Console.ReadLine());
    }

    static double add(double num1, double num2)
    {
        return num1 + num2;
    }

    static double subtract(double num1, double num2)
    {
        return num1 - num2;
    }

    static double multiply(double num1, double num2)
    {
        return num1 * num2;
    }

    static double divide(double num1, double num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("error: division by zero is not allowed.");
            return 0;
        }
        return num1 / num2;
    }

    static void displayresult(double result)
    {
        Console.WriteLine("result: " + result);
    }

    static void Main()
    {
        Console.WriteLine("select an operation:");
        Console.WriteLine("1. addition");
        Console.WriteLine("2. subtraction");
        Console.WriteLine("3. multiplication");
        Console.WriteLine("4. division");

        int choice = (int)getinput("enter your choice (1/2/3/4): ");
        double num1 = getinput("enter the first number: ");
        double num2 = getinput("enter the second number: ");
        double result = 0;

        switch (choice)
        {
            case 1:
                result = add(num1, num2);
                break;
            case 2:
                result = subtract(num1, num2);
                break;
            case 3:
                result = multiply(num1, num2);
                break;
            case 4:
                result = divide(num1, num2);
                break;
            default:
                Console.WriteLine("invalid choice.");
                return;
        }

        displayresult(result);
    }
}

