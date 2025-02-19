using System;
using System.Collections.Generic;

class BankingSystem
{
    Dictionary<int, double> accountBalances = new Dictionary<int, double>();
    SortedDictionary<double, List<int>> sortedBalances = new SortedDictionary<double, List<int>>();
    Queue<(int, double)> withdrawalQueue = new Queue<(int, double)>();

    public void CreateAccount(int accountId, double balance)
    {
        if (!accountBalances.ContainsKey(accountId))
        {
            accountBalances[accountId] = balance;
            if (!sortedBalances.ContainsKey(balance))
                sortedBalances[balance] = new List<int>();
            sortedBalances[balance].Add(accountId);
        }
    }

    public void Deposit(int accountId, double amount)
    {
        if (accountBalances.ContainsKey(accountId))
        {
            double oldBalance = accountBalances[accountId];
            accountBalances[accountId] += amount;

            sortedBalances[oldBalance].Remove(accountId);
            if (sortedBalances[oldBalance].Count == 0)
                sortedBalances.Remove(oldBalance);

            double newBalance = accountBalances[accountId];
            if (!sortedBalances.ContainsKey(newBalance))
                sortedBalances[newBalance] = new List<int>();
            sortedBalances[newBalance].Add(accountId);
        }
    }

    public void RequestWithdrawal(int accountId, double amount)
    {
        if (accountBalances.ContainsKey(accountId) && accountBalances[accountId] >= amount)
            withdrawalQueue.Enqueue((accountId, amount));
    }

    public void ProcessWithdrawals()
    {
        while (withdrawalQueue.Count > 0)
        {
            var (accountId, amount) = withdrawalQueue.Dequeue();
            if (accountBalances[accountId] >= amount)
            {
                double oldBalance = accountBalances[accountId];
                accountBalances[accountId] -= amount;

                sortedBalances[oldBalance].Remove(accountId);
                if (sortedBalances[oldBalance].Count == 0)
                    sortedBalances.Remove(oldBalance);

                double newBalance = accountBalances[accountId];
                if (!sortedBalances.ContainsKey(newBalance))
                    sortedBalances[newBalance] = new List<int>();
                sortedBalances[newBalance].Add(accountId);

                Console.WriteLine($"Withdrawal of ${amount} from Account {accountId} successful.");
            }
            else
            {
                Console.WriteLine($"Insufficient balance for Account {accountId}. Withdrawal failed.");
            }
        }
    }

    public void DisplayBalances()
    {
        Console.WriteLine("Account Balances:");
        foreach (var kvp in accountBalances)
            Console.WriteLine($"Account {kvp.Key}: ${kvp.Value}");
    }

    public void DisplaySortedBalances()
    {
        Console.WriteLine("\nAccounts Sorted by Balance:");
        foreach (var kvp in sortedBalances)
            foreach (var accountId in kvp.Value)
                Console.WriteLine($"Account {accountId}: ${kvp.Key}");
    }
}

class Program
{
    static void Main()
    {
        BankingSystem bank = new BankingSystem();

        bank.CreateAccount(101, 5000);
        bank.CreateAccount(102, 3000);
        bank.CreateAccount(103, 7000);
        bank.CreateAccount(104, 6000);

        bank.Deposit(102, 2000);
        bank.RequestWithdrawal(101, 1000);
        bank.RequestWithdrawal(103, 500);
        bank.RequestWithdrawal(104, 7000); 

        bank.DisplayBalances();
        bank.DisplaySortedBalances();

        Console.WriteLine("\nProcessing Withdrawals...");
        bank.ProcessWithdrawals();

        bank.DisplayBalances();
        bank.DisplaySortedBalances();
    }
}
