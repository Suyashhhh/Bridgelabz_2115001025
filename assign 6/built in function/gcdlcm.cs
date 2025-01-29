using System;
class Program
{
    static int getinput(string prompt)
    {
        Console.Write(prompt);
        return int.Parse(Console.ReadLine());
    }

    static int calculategcd(int num1, int num2)
    {
        while (num2 != 0)
        {
            int temp = num2;
            num2 = num1 % num2;
            num1 = temp;
        }
        return num1;
    }

    static int calculatelcm(int num1, int num2)
    {
        return (num1 * num2) / calculategcd(num1, num2);
    }

    static void displayresult(int gcd, int lcm)
    {
        Console.WriteLine("gcd: " + gcd);
        Console.WriteLine("lcm: " + lcm);
    }

    static void Main()
    {
        int num1 = getinput("enter the first number: ");
        int num2 = getinput("enter the second number: ");
        
        int gcd = calculategcd(num1, num2);
        int lcm = calculatelcm(num1, num2);
        
        displayresult(gcd, lcm);
    }
}

