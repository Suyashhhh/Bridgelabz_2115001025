using System;
class BankAccount {
    static string bankName;
    static int total = 0;
    readonly int AccountNumber;
    string AccountHolderName;

    public BankAccount(string Bankname, string Accountholdername, int Accountnumber) {
        bankName = Bankname;
        this.AccountHolderName = Accountholdername;
        this.AccountNumber = Accountnumber;
        total++;
    }

    public static void GetTotalAccounts() {
        Console.WriteLine("total no. of accounts: " + total);
    }

    public void DisplayDetails() {
        if (this is BankAccount) {
            Console.WriteLine("bank name: " + bankName);
            Console.WriteLine("account holder: " + AccountHolderName);
            Console.WriteLine("account number: " + AccountNumber);
        }
    }
}

class Program {
    static void Main() {
        BankAccount acc1 = new BankAccount("icicicicici", "raju", 12345);
        acc1.DisplayDetails();

        BankAccount acc2 = new BankAccount("MDH bank", "shaarda", 67890);
        acc2.DisplayDetails();

        BankAccount.GetTotalAccounts();
    }
}