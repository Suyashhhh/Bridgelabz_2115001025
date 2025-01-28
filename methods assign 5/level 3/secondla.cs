using System;

public class NumberChecker {
    public static int CountDigits(int number) {
        return number.ToString().Length;
    }

    public static bool IsDuckNumber(int number) {
        string numberStr = number.ToString();
        return numberStr.Contains("0") && numberStr[0] != '0';
    }

    public static bool IsArmstrongNumber(int number) {
        string numberStr = number.ToString();
        int sum = 0;
        int numDigits = numberStr.Length;
        foreach (char digitChar in numberStr) {
            int digit = digitChar - '0'; // Convert char to int
            sum += (int)Math.Pow(digit, numDigits);
        }
        return sum == number;
    }

    public static void Main() {
        int number = 153;

        Console.WriteLine($"Count of digits: {CountDigits(number)}");

        string numberStr = number.ToString();
        int[] digits = Array.ConvertAll(numberStr.ToCharArray(), c => c - '0');
        Console.WriteLine($"Digits: {string.Join(", ", digits)}");

        Console.WriteLine($"Is Duck Number: {IsDuckNumber(number)}");
        Console.WriteLine($"Is Armstrong Number: {IsArmstrongNumber(number)}");

        int largest = Int32.MinValue, secondLargest = Int32.MinValue;
        int smallest = Int32.MaxValue, secondSmallest = Int32.MaxValue;
        
        foreach (int digit in digits) {
            if (digit > largest) {
                secondLargest = largest;
                largest = digit;
            } else if (digit > secondLargest && digit != largest) {
                secondLargest = digit;
            }

            if (digit < smallest) {
                secondSmallest = smallest;
                smallest = digit;
            } else if (digit < secondSmallest && digit != smallest) {
                secondSmallest = digit;
            }
        }

        Console.WriteLine($"Largest: {largest}, Second Largest: {secondLargest}");
        Console.WriteLine($"Smallest: {smallest}, Second Smallest: {secondSmallest}");
    }
} 


