using System;

class Animal
{
    private string name;
    private int age;

    public Animal(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("animal makes a sound");
    }
}

class Dog : Animal
{
    public Dog(string name, int age) : base(name, age) {}

    public override void MakeSound()
    {
        Console.WriteLine("dog barks");
    }
}

class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) {}

    public override void MakeSound()
    {
        Console.WriteLine("cat meows");
    }
}

class Bird : Animal
{
    public Bird(string name, int age) : base(name, age) {}

    public override void MakeSound()
    {
        Console.WriteLine("bird chirps");
    }
}

class Program
{
    static void Main()
    {
        Animal a = new Animal("arun", 5);
        Dog d = new Dog("raju", 3);
        Cat c = new Cat("sita", 2);
        Bird b = new Bird("gopal", 1);

        a.MakeSound();
        d.MakeSound();
        c.MakeSound();
        b.MakeSound();
    }
}
