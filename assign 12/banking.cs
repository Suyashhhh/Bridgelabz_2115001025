using System;
using System.Collections.Generic;

interface ILoanable
{
    void ApplyForLoan(double amount);
    double CalculateLoanEligibility();
}

abstract class BankAccount
{
    private string accountNumber;
    private string holderName;
    private double balance;

    protected BankAccount(string number, string name, double initialBalance)
    {
        accountNumber = number;
        holderName = name;
        balance = initialBalance;
    }

    protected double GetBalance() => balance;

    public void Deposit(double amount) => balance += amount;

    public void Withdraw(double amount)
    {
        if (amount > balance) Console.WriteLine("insufficient funds");
        else balance -= amount;
    }

    public abstract double CalculateInterest();

    public void DisplayDetails()
    {
        Console.WriteLine($"{accountNumber}\t{holderName}\t{balance}\t{CalculateInterest()}");
    }
}

class SavingsAccount : BankAccount, ILoanable
{
    public SavingsAccount(string number, string name, double initialBalance) : base(number, name, initialBalance) { }

    public override double CalculateInterest() => GetBalance() * 0.04;

    public void ApplyForLoan(double amount) => Console.WriteLine("loan applied: " + amount);

    public double CalculateLoanEligibility() => GetBalance() * 5;
}

class CurrentAccount : BankAccount
{
    public CurrentAccount(string number, string name, double initialBalance) : base(number, name, initialBalance) { }

    public override double CalculateInterest() => GetBalance() * 0.02;
}

class Program
{
    static void Main()
    {
        var accounts = new List<BankAccount>
        {
            new SavingsAccount("SAV101", "Chintu", 10000),
            new CurrentAccount("CUR202", "Pintu", 15000),
            new SavingsAccount("SAV303", "Bablu", 20000),
            new CurrentAccount("CUR404", "Lallu", 18000)
        };

        Console.WriteLine("AccNo\tName\tBalance\tInterest");
        accounts.ForEach(a => a.DisplayDetails());

        SavingsAccount sa = new SavingsAccount("SAV505", "Mintu", 25000);
        sa.ApplyForLoan(50000);
        Console.WriteLine("loan eligibility: " + sa.CalculateLoanEligibility());
    }
}
