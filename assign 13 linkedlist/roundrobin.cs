
using System;

class ProcessNode
{
    public int ProcessId;
    public int BurstTime;
    public int Priority;
    public ProcessNode Next;

    public ProcessNode(int processId, int burstTime, int priority)
    {
        ProcessId = processId;
        BurstTime = burstTime;
        Priority = priority;
        Next = null;
    }
}

class RoundRobinScheduler
{
    public ProcessNode head;

    public void AddProcess(int processId, int burstTime, int priority)
    {
        ProcessNode newProcess = new ProcessNode(processId, burstTime, priority);
        if (head == null)
        {
            head = newProcess;
            head.Next = head;
            return;
        }
        ProcessNode temp = head;
        while (temp.Next != head)
        {
            temp = temp.Next;
        }
        temp.Next = newProcess;
        newProcess.Next = head;
    }

    public void RemoveProcess(int processId)
    {
        if (head == null) return;
        if (head.ProcessId == processId && head.Next == head)
        {
            head = null;
            return;
        }
        ProcessNode temp = head, prev = null;
        do
        {
            if (temp.ProcessId == processId)
            {
                if (prev != null) prev.Next = temp.Next;
                else
                {
                    ProcessNode last = head;
                    while (last.Next != head) last = last.Next;
                    head = head.Next;
                    last.Next = head;
                }
                return;
            }
            prev = temp;
            temp = temp.Next;
        } while (temp != head);
    }

    public void SimulateRoundRobin(int timeQuantum)
    {
        if (head == null) return;
        int totalWaitingTime = 0, totalTurnaroundTime = 0, processCount = 0;
        ProcessNode temp = head;
        do
        {
            if (temp.BurstTime > 0)
            {
                Console.WriteLine("executing process: " + temp.ProcessId + " | remaining burst time: " + Math.Max(0, temp.BurstTime - timeQuantum));
                temp.BurstTime -= timeQuantum;
                if (temp.BurstTime <= 0)
                {
                    totalTurnaroundTime += totalWaitingTime + timeQuantum + temp.BurstTime;
                    RemoveProcess(temp.ProcessId);
                    processCount++;
                }
                totalWaitingTime += timeQuantum;
            }
            temp = temp.Next;
        } while (head != null);
        Console.WriteLine("average waiting time: " + Math.Round((double)totalWaitingTime / processCount, 2));
        Console.WriteLine("average turnaround time: " + Math.Round((double)totalTurnaroundTime / processCount, 2));
    }

    public void DisplayProcesses()
    {
        if (head == null) return;
        ProcessNode temp = head;
        do
        {
            Console.WriteLine(temp.ProcessId + "\t" + temp.BurstTime + "\t" + temp.Priority);
            temp = temp.Next;
        } while (temp != head);
    }
}

class Program
{
    static void Main()
    {
        RoundRobinScheduler scheduler = new RoundRobinScheduler();

        scheduler.AddProcess(1, 10, 2);
        
        Console.WriteLine("processes in the queue:");
        scheduler.DisplayProcesses();
        Console.WriteLine();

        Console.WriteLine("simulating round-robin scheduling with time quantum 4:");
        scheduler.SimulateRoundRobin(4);
        Console.WriteLine();

        Console.WriteLine("remaining processes after scheduling:");
        scheduler.DisplayProcesses();
    }
}

