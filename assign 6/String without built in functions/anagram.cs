using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the first string: ");
        string str1 = Console.ReadLine();
        Console.Write("Enter the second string: ");
        string str2 = Console.ReadLine();

        if (str1.Length != str2.Length)
        {
            Console.WriteLine("No");
        }
        else
        {
            char[] arr1 = str1.ToCharArray();
            char[] arr2 = str2.ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);

            bool isAnagram = true;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    isAnagram = false;
                    break;
                }
            }
            if (isAnagram)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

