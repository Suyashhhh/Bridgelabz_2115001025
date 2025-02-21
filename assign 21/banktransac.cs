using System;

class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message) { }
}

class BankAccount
{
    public double Balance { get; private set; }

    public BankAccount(double initialBalance)
    {
        Balance = initialBalance;
    }

    public void Withdraw(double amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("invalid amount!");
        }
        if (amount > Balance)
        {
            throw new InsufficientFundsException("insufficient balance!");
        }
        Balance -= amount;
        Console.WriteLine("withdrawal successful, new balance: " + Math.Round(Balance, 2));
    }
}

class Program
{
    public static void Main()
    {
        BankAccount account = new BankAccount(5000);

        try
        {
            Console.WriteLine("enter withdrawal amount:");
            double amount = double.Parse(Console.ReadLine());
            account.Withdraw(amount);
        }
        catch (InsufficientFundsException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("invalid input: please enter a numeric value");
        }
    }
}
