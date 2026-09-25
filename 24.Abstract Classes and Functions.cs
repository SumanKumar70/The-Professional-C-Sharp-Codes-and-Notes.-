using System;
abstract class Shape
{
    public abstract void CalculateArea();
}

class Circle : Shape
{
    public double Radius = 5;

    public override void CalculateArea()
    {
        double area = 3.14 * Radius * Radius;
        Console.WriteLine("Area of Circle: " + area);
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle();

        circle.CalculateArea();
    }
}
