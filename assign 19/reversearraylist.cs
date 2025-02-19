using System;
using System.Collections.Generic;

class Program
{
    static void ReverseList<T>(List<T> list)
    {
        int left = 0, right = list.Count - 1;
        while (left < right)
        {
            (list[left], list[right]) = (list[right], list[left]);
            left++;
            right--;
        }
    }

    static LinkedList<T> ReverseLinkedList<T>(LinkedList<T> list)
    {
        LinkedList<T> reversed = new LinkedList<T>();
        foreach (T item in list)
            reversed.AddFirst(item);
        return reversed;
    }

    static void Main()
    {
        List<int> arrayList = new List<int> { 1, 2, 3, 4, 5 };
        ReverseList(arrayList);
        Console.WriteLine(string.Join(", ", arrayList));

        LinkedList<int> linkedList = new LinkedList<int>(new int[] { 1, 2, 3, 4, 5 });
        LinkedList<int> reversedLinkedList = ReverseLinkedList(linkedList);
        Console.WriteLine(string.Join(", ", reversedLinkedList));
    }
}
