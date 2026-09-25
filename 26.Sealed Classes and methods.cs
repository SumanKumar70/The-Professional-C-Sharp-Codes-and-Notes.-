using System;

class Vehicle
{
    public virtual void Start()
    {
        Console.WriteLine("Vehicle starts");
    }
}

class Car : Vehicle
{
    
    public sealed override void Start()
    {
        Console.WriteLine("Car starts");
    }
}

class SportsCar : Car
{
 
}

class Program
{
    static void Main()
    {
        SportsCar car = new SportsCar();

        car.Start();
    }
}