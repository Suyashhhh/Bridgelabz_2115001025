using System;
class Circle
{
    public double radius;

    public Circle() : this(1.0) { }// chained const.
	public Circle(double radius)
    {
        this.radius = radius;
    }

    public void display()
    {
        Console.WriteLine($"radius: {radius}");
    }

    static void Main()
    {
        Circle circle1 = new Circle();
        circle1.display();
        Circle circle2 = new Circle(5.5);
        circle2.display();
    }
}
