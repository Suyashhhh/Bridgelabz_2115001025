
using System;

class ItemNode
{
    public string ItemName;
    public int ItemId;
    public int Quantity;
    public double Price;
    public ItemNode Next;

    public ItemNode(string itemName, int itemId, int quantity, double price)
    {
        ItemName = itemName;
        ItemId = itemId;
        Quantity = quantity;
        Price = price;
        Next = null;
    }
}

class Inventory
{
    public ItemNode head;

    public void AddAtBeginning(ItemNode newItem)
    {
        newItem.Next = head;
        head = newItem;
    }

    public void AddAtEnd(ItemNode newItem)
    {
        if (head == null)
        {
            head = newItem;
            return;
        }
        ItemNode temp = head;
        while (temp.Next != null)
        {
            temp = temp.Next;
        }
        temp.Next = newItem;
    }

    public void AddAtPosition(ItemNode newItem, int position)
    {
        if (position == 1)
        {
            AddAtBeginning(newItem);
            return;
        }
        ItemNode temp = head;
        int count = 1;
        while (temp != null && count < position - 1)
        {
            temp = temp.Next;
            count++;
        }
        if (temp == null)
        {
            Console.WriteLine("position out of range");
            return;
        }
        newItem.Next = temp.Next;
        temp.Next = newItem;
    }

    public void RemoveByItemId(int itemId)
    {
        if (head == null) return;
        if (head.ItemId == itemId)
        {
            head = head.Next;
            return;
        }
        ItemNode temp = head;
        while (temp.Next != null && temp.Next.ItemId != itemId)
        {
            temp = temp.Next;
        }
        if (temp.Next == null) return;
        temp.Next = temp.Next.Next;
    }

    public void UpdateQuantity(int itemId, int newQuantity)
    {
        ItemNode temp = head;
        while (temp != null)
        {
            if (temp.ItemId == itemId)
            {
                temp.Quantity = newQuantity;
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("item not found");
    }

    public void SearchItem(string searchTerm)
    {
        ItemNode temp = head;
        bool found = false;
        while (temp != null)
        {
            if (temp.ItemName == searchTerm || temp.ItemId.ToString() == searchTerm)
            {
                Console.WriteLine(temp.ItemId + "\t" + temp.ItemName + "\t" + temp.Quantity + "\t" + temp.Price);
                found = true;
            }
            temp = temp.Next;
        }
        if (!found) Console.WriteLine("item not found");
    }

    public void CalculateTotalValue()
    {
        double totalValue = 0;
        ItemNode temp = head;
        while (temp != null)
        {
            totalValue += temp.Price * temp.Quantity;
            temp = temp.Next;
        }
        Console.WriteLine("total inventory value: " + totalValue);
    }

    public void DisplayAllItems()
    {
        ItemNode temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.ItemId + "\t" + temp.ItemName + "\t" + temp.Quantity + "\t" + temp.Price);
            temp = temp.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        Inventory inventory = new Inventory();

        inventory.AddAtEnd(new ItemNode("apple", 101, 50, 1.5));

        Console.WriteLine("all items:");
        inventory.DisplayAllItems();
        Console.WriteLine();

        Console.WriteLine("searching for item 'apple':");
        inventory.SearchItem("apple");
        Console.WriteLine();

        Console.WriteLine("updating quantity of item 101:");
        inventory.UpdateQuantity(101, 60);
        inventory.DisplayAllItems();
        Console.WriteLine();

        Console.WriteLine("calculating total inventory value:");
        inventory.CalculateTotalValue();
        Console.WriteLine();

        Console.WriteLine("removing item 101:");
        inventory.RemoveByItemId(101);
        inventory.DisplayAllItems();
    }
}

