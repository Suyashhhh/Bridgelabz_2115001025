using System;
using System.Collections.Generic;

public class ListManager
{
    public void AddElement(List<int> list, int element)
    {
        list.Add(element);
    }

    public void RemoveElement(List<int> list, int element)
    {
        if (!list.Remove(element))
        {
            Console.WriteLine("element not found in the list");
        }
    }

    public int GetSize(List<int> list)
    {
        return list.Count;
    }
}




using NUnit.Framework;
using System.Collections.Generic;

[TestFixture]
public class ListManagerTests
{
    private ListManager listManager;
    private List<int> list;

    [SetUp]
    public void Setup()
    {
        listManager = new ListManager();
        list = new List<int>();
    }

    [Test]
    public void AddElement_ShouldAddElementToList()
    {
        listManager.AddElement(list, 10);
        Assert.Contains(10, list);
    }

    [Test]
    public void RemoveElement_ShouldRemoveElementFromList()
    {
        listManager.AddElement(list, 20);
        listManager.RemoveElement(list, 20);
        Assert.IsFalse(list.Contains(20));
    }

    [Test]
    public void RemoveElement_ShouldHandleNonExistentElement()
    {
        listManager.RemoveElement(list, 30);
        Assert.AreEqual(0, list.Count);
    }

    [Test]
    public void GetSize_ShouldReturnCorrectSize()
    {
        listManager.AddElement(list, 5);
        listManager.AddElement(list, 15);
        int size = listManager.GetSize(list);
        Assert.AreEqual(2, size);
    }
}
