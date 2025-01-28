using System;

public class NumberChecker {
    public static bool IsPrime(int number) {
        if (number <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(number); i++) {
            if (number % i == 0) return false;
        }
        return true;
    }

    public static bool IsNeon(int number) {
        int square = number * number;
        int sumOfDigits = 0;
        while (square > 0) {
            sumOfDigits += square % 10;
            square /= 10;
        }
        return sumOfDigits == number;
    }

    public static bool IsSpy(int number) {
        int sum = 0, product = 1;
        while (number > 0) {
            int digit = number % 10;
            sum += digit;
            product *= digit;
            number /= 10;
        }
        return sum == product;
    }

    public static bool IsAutomorphic(int number) {
        int square = number * number;
        int temp = number;
        while (temp > 0) {
            if (square % 10 != temp % 10) return false;
            square /= 10;
            temp /= 10;
        }
        return true;
    }

    public static bool IsBuzz(int number) {
        return number % 7 == 0 || number % 10 == 7;
    }

    public static void Main() {
        int number = 25;

        Console.WriteLine($"Is Prime: {IsPrime(number)}");
        Console.WriteLine($"Is Neon: {IsNeon(number)}");
        Console.WriteLine($"Is Spy: {IsSpy(number)}");
        Console.WriteLine($"Is Automorphic: {IsAutomorphic(number)}");
        Console.WriteLine($"Is Buzz: {IsBuzz(number)}");
    }
}

