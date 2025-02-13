using System;

class HashMap
{
    private int size = 1000;
    private int?[] table;

    public HashMap() 
    { 
        table = new int?[size]; 
    }

    private int Hash(int key) 
    { 
        return Math.Abs(key) % size; 
    }

    public void Insert(int key, int value) 
    { 
        table[Hash(key)] = value; 
    }

    public int Get(int key) 
    { 
        return table[Hash(key)] ?? -1; 
    }

    public void Remove(int key) 
    { 
        table[Hash(key)] = null; 
    }

    public void Display()
    {
        for (int i = 0; i < size; i++)
        {
            if (table[i] != null) 
                Console.WriteLine("key " + i + " -> " + table[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        HashMap map = new HashMap();

        map.Insert(1, 100);
        map.Insert(2, 200);
        map.Insert(11, 300);
        map.Insert(3, 150);
        map.Insert(2, 250);

        Console.WriteLine("value for key 2: " + map.Get(2));
        Console.WriteLine("value for key 5: " + map.Get(5));

        map.Remove(11);
        map.Display();
    }
}
