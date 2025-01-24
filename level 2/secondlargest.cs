
using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int maxDigit = 10, index = 0;
        int[] digits = new int[maxDigit];
        
        while (number != 0)
        {
            if (index == maxDigit) break;
            digits[index++] = number % 10;
            number /= 10;
        }

        int largest = -1, secondLargest = -1;
        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] < largest)
            {
                secondLargest = digits[i];
            }
        }

        Console.WriteLine($"The largest digit is: {largest}");
        Console.WriteLine($"The second largest digit is: {secondLargest}");
    }
}

