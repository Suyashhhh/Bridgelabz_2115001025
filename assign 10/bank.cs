using System;
using System.Collections.Generic;

class Bank
{
    private string name;
    private string bankID;
    private List<Customer> customers = new List<Customer>();

    public Bank(string name, string bankID)
    {
        this.name = name;
        this.bankID = bankID;
    }

    public void OpenAccount(Customer customer, string accountNo, double initialBalance)
    {
        Account newAccount = new Account(accountNo, initialBalance);
        customer.AddAccount(newAccount);
        if (!customers.Contains(customer))
            customers.Add(customer);
        Console.WriteLine("account opened for " + customer.GetName() + " with balance: " + initialBalance);
    }

    public string GetName() { return name; }
}

class Customer
{
    private string name;
    private string customerID;
    private List<Account> accounts = new List<Account>();

    public Customer(string name, string customerID)
    {
        this.name = name;
        this.customerID = customerID;
    }

    public void AddAccount(Account account)
    {
        accounts.Add(account);
    }

    public void ViewBalance()
    {
        Console.WriteLine("customer: " + name);
        foreach (var acc in accounts)
            Console.WriteLine("account: " + acc.GetAccountNo() + "\tbalance: " + acc.GetBalance());
    }

    public string GetName() { return name; }
}

class Account
{
    private string accountNo;
    private double balance;

    public Account(string accountNo, double balance)
    {
        this.accountNo = accountNo;
        this.balance = balance;
    }

    public string GetAccountNo() { return accountNo; }
    public double GetBalance() { return balance; }
}

class Program
{
    static void Main()
    {
        Bank abcBank = new Bank("ABC Bank", "B001");
        Customer alice = new Customer("Alice", "C101");
        Customer bob = new Customer("Bob", "C102");

        abcBank.OpenAccount(alice, "A1001", 5000);
        abcBank.OpenAccount(alice, "A1002", 3000);
        abcBank.OpenAccount(bob, "B2001", 7000);

        Console.WriteLine();
        alice.ViewBalance();
        Console.WriteLine();
        bob.ViewBalance();
    }
}
