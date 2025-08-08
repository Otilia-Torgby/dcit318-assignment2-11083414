using System;

 
class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic sound");
    }
}


class Dog : Animal
{
    
    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }
}


class Cat : Animal
{
   
    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }
}


class Program
{
    static void Main()
    {
       
        Animal genericAnimal = new Animal();
        Dog myDog = new Dog();
        Cat myCat = new Cat();

        // Calling the MakeSound method on each
        genericAnimal.MakeSound(); // Output: Some generic sound
        myDog.MakeSound();         // Output: Bark
        myCat.MakeSound();         // Output: Meow

        // Keeps the window open after running (for testing in VS Code)
        Console.ReadLine();
    }
}
