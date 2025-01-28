using System;

public class NumberComparison {
    public bool IsPositive(int number) {
        return number >= 0;
    }

    public string IsEven(int number) {
        return number % 2 == 0 ? "even" : "odd";
    }

    public int Compare(int num1, int num2) {
        if (num1 > num2) return 1;
        if (num1 == num2) return 0;
        return -1;
    }

    public static void Main() {
        NumberComparison comparison = new NumberComparison();
        int[] numbers = new int[5];

        for (int i = 0; i < 5; i++) {
            numbers[i] = int.Parse(Console.ReadLine());

            if (comparison.IsPositive(numbers[i])) {
                Console.WriteLine($"{numbers[i]} is positive and {comparison.IsEven(numbers[i])}.");
            } else {
                Console.WriteLine($"{numbers[i]} is negative.");
            }
        }

        int compareResult = comparison.Compare(numbers[0], numbers[4]);
        if (compareResult == 1) {
            Console.WriteLine("first element is greater than last element.");
        } else if (compareResult == 0) {
            Console.WriteLine("first and last elements are equal.");
        } else {
            Console.WriteLine("first element is less than last element.");
        }
    }
}

