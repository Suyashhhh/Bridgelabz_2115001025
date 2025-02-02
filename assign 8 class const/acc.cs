using System;
class BankAccount
{
    public string accountNumber;
    protected string accountHolder;
    private double balance;

    public void SetBalance(double amount)
    {
        balance = amount;
    }

    public double BalanceAmount // public property to get balance directly
    {
        get { return balance; }
    }
}

class SavingsAccount : BankAccount
{
    public void DisplayAccountDetails()
    {
        Console.WriteLine($"Account Number: {accountNumber}, Account Holder: {accountHolder}");
    }

    static void Main()
    {
        SavingsAccount sAccount = new SavingsAccount();
        sAccount.accountNumber = "235476";
        sAccount.SetBalance(69999);
        sAccount.DisplayAccountDetails();
        Console.WriteLine($"Balance: {sAccount.BalanceAmount}"); // using property to access balance
    }
}
