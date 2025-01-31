using System;
class Circle{
    int radius;
    
    public Circle(int radius) {
        this.radius=radius;
    }

    public void circumference() {
        Console.WriteLine("circumference is" +2*Math.PI*radius);
    }
	public void area(){
		Console.WriteLine("area of the circle:"+Math.PI*radius*radius);
	}

    static void Main() {
        Circle ex1 = new Circle(12); // creating object of the methodd
		
		ex1.circumference(); // calling the method to give circumference
		ex1.area();//for area
	}
}