using System;


abstract class Shape
{
    public abstract double GetArea();
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    // Implementing the abstract method
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

// Rectangle class (inherits from Shape)
class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    // Constructor to set width and height
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    // Implementing the abstract method
    public override double GetArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main()
    {
        // Testing Circle
        Circle myCircle = new Circle(5); // radius = 5
        Console.WriteLine($"Circle area: {myCircle.GetArea()}");

        // Testing Rectangle
        Rectangle myRectangle = new Rectangle(4, 6); // width = 4, height = 6
        Console.WriteLine($"Rectangle area: {myRectangle.GetArea()}");

        // Keep window open in VS Code
        Console.ReadLine();
    }
}
