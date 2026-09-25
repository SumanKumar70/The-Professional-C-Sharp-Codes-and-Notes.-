using System;

class Vehicle
{
    public void Start()
    {
        Console.WriteLine("Vehicle is starting");
    }
}

class Car : Vehicle
{
}

class Bike : Vehicle
{
}

class Program
{
    static void Main(string[]args)
    {
        Car car = new Car();

        Bike bike = new Bike();
        car.Start();
        bike.Start();
    }
}
