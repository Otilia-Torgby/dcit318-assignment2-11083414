using System;

// Interface for anything that can move
interface IMovable
{
    void Move();
}

// Car class implementing IMovable
class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

//Bicycle class implementing IMovable
class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Program
{
    static void Main()
    {
        // Creating objects
        Car myCar = new Car();
        Bicycle myBicycle = new Bicycle();

        // Calling the Move method on each
        myCar.Move();      // Output: Car is moving
        myBicycle.Move();  // Output: Bicycle is moving

        // Keep window open for VS Code users
        Console.ReadLine();
    }
}
