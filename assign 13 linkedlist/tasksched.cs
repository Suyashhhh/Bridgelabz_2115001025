
using System;

class TaskNode
{
    public int TaskId;
    public string TaskName;
    public int Priority;
    public string DueDate;
    public TaskNode Next;

    public TaskNode(int taskId, string taskName, int priority, string dueDate)
    {
        TaskId = taskId;
        TaskName = taskName;
        Priority = priority;
        DueDate = dueDate;
        Next = null;
    }
}

class TaskScheduler
{
    public TaskNode head;
    public TaskNode current;

    public void AddAtBeginning(TaskNode newTask)
    {
        if (head == null)
        {
            head = newTask;
            head.Next = head;
        }
        else
        {
            TaskNode temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            newTask.Next = head;
            temp.Next = newTask;
            head = newTask;
        }
    }

    public void AddAtEnd(TaskNode newTask)
    {
        if (head == null)
        {
            head = newTask;
            head.Next = head;
        }
        else
        {
            TaskNode temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            temp.Next = newTask;
            newTask.Next = head;
        }
    }

    public void AddAtPosition(TaskNode newTask, int position)
    {
        if (position <= 1)
        {
            AddAtBeginning(newTask);
            return;
        }

        TaskNode temp = head;
        int i = 1;
        while (i < position - 1 && temp.Next != head)
        {
            temp = temp.Next;
            i++;
        }

        newTask.Next = temp.Next;
        temp.Next = newTask;
    }

    public void RemoveByTaskId(int taskId)
    {
        if (head == null) return;

        if (head.TaskId == taskId)
        {
            if (head.Next == head)
            {
                head = null;
                return;
            }

            TaskNode temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            head = head.Next;
            temp.Next = head;
            return;
        }

        TaskNode current = head;
        while (current.Next != head && current.Next.TaskId != taskId)
        {
            current = current.Next;
        }

        if (current.Next.TaskId == taskId)
        {
            current.Next = current.Next.Next;
        }
    }

    public void ViewCurrentTask()
    {
        if (current == null) current = head;
        if (current != null)
        {
            Console.WriteLine(current.TaskId + "\t" + current.TaskName + "\t" + current.Priority + "\t" + current.DueDate);
        }
    }

    public void MoveToNextTask()
    {
        if (current == null) current = head;
        if (current != null) current = current.Next;
    }

    public void DisplayAllTasks()
    {
        if (head == null) return;
        TaskNode temp = head;
        do
        {
            Console.WriteLine(temp.TaskId + "\t" + temp.TaskName + "\t" + temp.Priority + "\t" + temp.DueDate);
            temp = temp.Next;
        } while (temp != head);
    }

    public void SearchByPriority(int priority)
    {
        if (head == null) return;
        TaskNode temp = head;
        bool found = false;
        do
        {
            if (temp.Priority == priority)
            {
                Console.WriteLine(temp.TaskId + "\t" + temp.TaskName + "\t" + temp.Priority + "\t" + temp.DueDate);
                found = true;
            }
            temp = temp.Next;
        } while (temp != head);
        if (!found) Console.WriteLine("no tasks found");
    }
}

class Program
{
    static void Main()
    {
        TaskScheduler scheduler = new TaskScheduler();

        scheduler.AddAtEnd(new TaskNode(101, "task 1", 2, "2025-02-15"));
        scheduler.AddAtEnd(new TaskNode(102, "task 2", 1, "2025-02-20"));
        scheduler.AddAtEnd(new TaskNode(103, "task 3", 3, "2025-02-25"));

        Console.WriteLine("all tasks:");
        scheduler.DisplayAllTasks();
        Console.WriteLine();

        Console.WriteLine("viewing current task:");
        scheduler.ViewCurrentTask();
        scheduler.MoveToNextTask();
        scheduler.ViewCurrentTask();
        Console.WriteLine();

        Console.WriteLine("searching for priority 2:");
        scheduler.SearchByPriority(2);
        Console.WriteLine();

        Console.WriteLine("removing task with id 101:");
        scheduler.RemoveByTaskId(101);
        scheduler.DisplayAllTasks();
        Console.WriteLine();

        Console.WriteLine("adding a task at the beginning:");
        scheduler.AddAtBeginning(new TaskNode(104, "task 4", 1, "2025-03-01"));
        scheduler.DisplayAllTasks();
        Console.WriteLine();
    }
}

