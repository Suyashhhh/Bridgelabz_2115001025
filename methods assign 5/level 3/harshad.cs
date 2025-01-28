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

    public static int SumOfDigits(int number) {
        int[] digits = StoreDigits(number);
        int sum = 0;
        foreach (int digit in digits) {
            sum += digit;
        }
        return sum;
    }

    public static double SumOfSquaresOfDigits(int number) {
        int[] digits = StoreDigits(number);
        double sumOfSquares = 0;
        foreach (int digit in digits) {
            sumOfSquares += Math.Pow(digit, 2);
        }
        return sumOfSquares;
    }

    public static bool IsHarshadNumber(int number) {
        int sum = SumOfDigits(number);
        return number % sum == 0;
    }

    public static int[,] DigitFrequency(int number) {
        int[] digits = StoreDigits(number);
        int[,] frequency = new int[10, 2]; // 10 digits (0-9), first column for digit, second for frequency
        foreach (int digit in digits) {
            frequency[digit, 0] = digit;
            frequency[digit, 1]++;
        }
        return frequency;
    }

    public static void Main() {
        int number = 21;

        Console.WriteLine($"Count of digits: {CountDigits(number)}");

        int[] digits = StoreDigits(number);
        Console.WriteLine($"Digits: {string.Join(", ", digits)}");

        Console.WriteLine($"Sum of digits: {SumOfDigits(number)}");

        Console.WriteLine($"Sum of squares of digits: {SumOfSquaresOfDigits(number)}");

        Console.WriteLine($"Is Harshad number: {IsHarshadNumber(number)}");

        int[,] frequency = DigitFrequency(number);
        Console.WriteLine("Digit frequency:");
        for (int i = 0; i < 10; i++) {
            if (frequency[i, 1] > 0) {
                Console.WriteLine($"{frequency[i, 0]}: {frequency[i, 1]}");
            }
        }
    }
}

