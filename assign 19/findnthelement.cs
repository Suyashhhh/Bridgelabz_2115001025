using System;
using System.Collections.Generic;

class Program
{
    static string FindNthFromEnd(LinkedList<string> list, int n)
    {
        LinkedListNode<string> first = list.First, second = list.First;
        for (int i = 0; i < n; i++)
            if (first != null) first = first.Next;
            else return "N is too large";

        while (first != null)
        {
            first = first.Next;
            second = second.Next;
        }
        return second.Value;
    }

    static void Main()
    {
        LinkedList<string> list = new LinkedList<string>(new string[] { "A", "B", "C", "D", "E" });
        int n = 2;
        Console.WriteLine(FindNthFromEnd(list, n));
    }
}
