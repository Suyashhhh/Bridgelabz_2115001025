using System;
using System.Threading;

public class TaskManager
{
    public string LongRunningTask()
    {
        Thread.Sleep(3000); // Simulates a long-running task (3 seconds)
        return "task completed";
    }
}




using NUnit.Framework;

[TestFixture]
public class TaskManagerTests
{
    private TaskManager taskManager;

    [SetUp]
    public void Setup()
    {
        taskManager = new TaskManager();
    }

    [Test, Timeout(2000)]
    public void LongRunningTask_ShouldFailIfTakesMoreThan2Seconds()
    {
        string result = taskManager.LongRunningTask();
        Assert.AreEqual("task completed", result);
    }
}

