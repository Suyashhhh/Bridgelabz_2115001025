using System;
using System.Text.RegularExpressions;

public class CreditCardValidator
{
    public bool IsValidVisa(string cardNumber)
    {
        string visaPattern = @"^4[0-9]{15}$";
        return Regex.IsMatch(cardNumber, visaPattern);
    }

    public bool IsValidMasterCard(string cardNumber)
    {
        string masterCardPattern = @"^5[1-5][0-9]{14}$";
        return Regex.IsMatch(cardNumber, masterCardPattern);
    }
}

public class Program
{
    public static void Main()
    {
        CreditCardValidator validator = new CreditCardValidator();

        string[] testCards = {
            "4123456789012345", // Visa (Valid)
            "5123456789012345", // MasterCard (Valid)
            "6123456789012345", // Invalid (Wrong prefix)
        };

        Console.WriteLine("Credit Card Validation Results:");
        foreach (string card in testCards)
        {
            bool isVisa = validator.IsValidVisa(card);
            bool isMasterCard = validator.IsValidMasterCard(card);

            string result = isVisa ? "Valid Visa" :
                            isMasterCard ? "Valid MasterCard" : "Invalid";
            Console.WriteLine($"{card} → {result}");
        }
    }
}
