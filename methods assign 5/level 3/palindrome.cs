using System;

public class NumberChecker {
    public static int CountDigits(int number) {
        return number.ToString().Length;
    }

    public static int[] StoreDigits(int number) {
        string numberStr = number.ToString();
        int[] digits = new int[numberStr.Length];
        for (int i = 0; i < numberStr.Length; i++) {
            digits[i] = numberStr[i] - '0'; // Convert char to int
        }
        return digits;
    }

    public static int[] ReverseDigits(int[] digits) {
        Array.Reverse(digits);
        return digits;
    }

    public static bool AreArraysEqual(int[] array1, int[] array2) {
        if (array1.Length != array2.Length) return false;
        for (int i = 0; i < array1.Length; i++) {
            if (array1[i] != array2[i]) return false;
        }
        return true;
    }

    public static bool IsPalindrome(int number) {
        int[] digits = StoreDigits(number);
        int[] reversedDigits = ReverseDigits((int[])digits.Clone());
        return AreArraysEqual(digits, reversedDigits);
    }

    public static bool IsDuckNumber(int number) {
        int[] digits = StoreDigits(number);
        foreach (int digit in digits) {
            if (digit != 0) {
                return true;
            }
        }
        return false;
    }

    public static void Main() {
        int number = 121;

        Console.WriteLine($"Count of digits: {CountDigits(number)}");

        int[] digits = StoreDigits(number);
        Console.WriteLine($"Digits: {string.Join(", ", digits)}");

        int[] reversedDigits = ReverseDigits((int[])digits.Clone());
        Console.WriteLine($"Reversed digits: {string.Join(", ", reversedDigits)}");

        Console.WriteLine($"Are digits and reversed digits equal: {AreArraysEqual(digits, reversedDigits)}");

        Console.WriteLine($"Is Palindrome: {IsPalindrome(number)}");    
       Console.WriteLine($"Is Duck Number: {IsDuckNumber(number)}");
    }
}

