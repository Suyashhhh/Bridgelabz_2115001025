using System;

public class BankAccount
{
    public double Balance { get; private set; }

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("deposit amount must be positive");
        }
        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("withdrawal amount must be positive");
        }
        if (amount > Balance)
        {
            throw new InvalidOperationException("insufficient funds");
        }
        Balance -= amount;
    }

    public double GetBalance()
    {
        return Balance;
    }
}






using NUnit.Framework;
using System;

[TestFixture]
public class BankAccountTests
{
    private BankAccount bankAccount;

    [SetUp]
    public void Setup()
    {
        bankAccount = new BankAccount();
    }

    [Test]
    public void Deposit_ShouldIncreaseBalance()
    {
        bankAccount.Deposit(100);
        Assert.AreEqual(100, bankAccount.GetBalance());

        bankAccount.Deposit(50);
        Assert.AreEqual(150, bankAccount.GetBalance());
    }

    [Test]
    public void Withdraw_ShouldDecreaseBalance()
    {
        bankAccount.Deposit(200);
        bankAccount.Withdraw(50);
        Assert.AreEqual(150, bankAccount.GetBalance());
    }

    [Test]
    public void Withdraw_ShouldFail_WhenInsufficientFunds()
    {
        bankAccount.Deposit(100);
        Assert.Throws<InvalidOperationException>(() => bankAccount.Withdraw(200));
    }

    [Test]
    public void Deposit_NegativeAmount_ShouldThrowException()
    {
        Assert.Throws<ArgumentException>(() => bankAccount.Deposit(-50));
    }

    [Test]
    public void Withdraw_NegativeAmount_ShouldThrowException()
    {
        Assert.Throws<ArgumentException>(() => bankAccount.Withdraw(-30));
    }
}


