using System;

public class NumberChecker {

    public static int[] FindFactors(int number) {
        int count = 0;
        for (int i = 1; i <= number; i++) {
            if (number % i == 0) count++;
        }

        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= number; i++) {
            if (number % i == 0) {
                factors[index] = i;
                index++;
            }
        }
        return factors;
    }

    public static int GreatestFactor(int number) {
        int[] factors = FindFactors(number);
        return factors[factors.Length - 1];
    }

    public static int SumOfFactors(int number) {
        int[] factors = FindFactors(number);
        int sum = 0;
        foreach (int factor in factors) {
            sum += factor;
        }
        return sum;
    }

    public static int ProductOfFactors(int number) {
        int[] factors = FindFactors(number);
        int product = 1;
        foreach (int factor in factors) {
            product *= factor;
        }
        return product;
    }

    public static double ProductOfCubesOfFactors(int number) {
        int[] factors = FindFactors(number);
        double productOfCubes = 1;
        foreach (int factor in factors) {
            productOfCubes *= Math.Pow(factor, 3);
        }
        return productOfCubes;
    }

    public static bool IsPerfectNumber(int number) {
        int sum = SumOfFactors(number) - number; // excluding the number itself
        return sum == number;
    }

    public static bool IsAbundantNumber(int number) {
        int sum = SumOfFactors(number) - number; // excluding the number itself
        return sum > number;
    }

    public static bool IsDeficientNumber(int number) {
        int sum = SumOfFactors(number) - number; // excluding the number itself
        return sum < number;
    }

    public static bool IsStrongNumber(int number) {
        int sumOfFactorials = 0;
        int temp = number;
        while (temp > 0) {
            int digit = temp % 10;
            sumOfFactorials += Factorial(digit);
            temp /= 10;
        }
        return sumOfFactorials == number;
    }

    public static int Factorial(int n) {
        int result = 1;
        for (int i = 1; i <= n; i++) {
            result *= i;
        }
        return result;
    }

    public static void Main() {
        int number = 145;

        Console.WriteLine($"Factors of {number}: {string.Join(", ", FindFactors(number))}");
        Console.WriteLine($"Greatest Factor: {GreatestFactor(number)}");
        Console.WriteLine($"Sum of Factors: {SumOfFactors(number)}");
        Console.WriteLine($"Product of Factors: {ProductOfFactors(number)}");
        Console.WriteLine($"Product of Cubes of Factors: {ProductOfCubesOfFactors(number)}");
        Console.WriteLine($"Is Perfect Number: {IsPerfectNumber(number)}");
        Console.WriteLine($"Is Abundant Number: {IsAbundantNumber(number)}");
        Console.WriteLine($"Is Deficient Number: {IsDeficientNumber(number)}");
        Console.WriteLine($"Is Strong Number: {IsStrongNumber(number)}");
    }
} 

