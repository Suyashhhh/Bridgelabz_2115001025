using System;
class Person
{
    public string name;
    public int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public Person(Person other)//this is the copy of const...
    {
        this.name = other.name;
        this.age = other.age;
    }

    public void display()
    {
        Console.WriteLine($"name: {name}, age: {age}");
    }

    static void Main()
    {
        Person person1 = new Person("pillu ", 20);
        person1.display();
        Person person2 = new Person(person1);  // using the copy constructor
        person2.display();
    }
}
