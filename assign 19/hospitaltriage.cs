using System;
using System.Collections.Generic;

class Program
{
    static void HospitalTriage(List<(string name, int severity)> patients)
    {
        PriorityQueue<string, int> queue = new PriorityQueue<string, int>();

        foreach (var patient in patients)
            queue.Enqueue(patient.name, -patient.severity);

        while (queue.Count > 0)
            Console.WriteLine(queue.Dequeue());
    }

    static void Main()
    {
        List<(string, int)> patients = new List<(string, int)>
        {
            ("John", 3), ("Alice", 5), ("Bob", 2)
        };

        HospitalTriage(patients);
    }
}
