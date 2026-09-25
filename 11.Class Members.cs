using System;

class Car
{
  
    private string brand;
    private double price;

    
    public string Color { get; set; }

   
    public void DisplayDetails()
    {
        Console.WriteLine("Brand: " + brand);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Color: " + Color);
    }

    
    public Car(string carBrand, double carPrice, string carColor)
    {
        brand = carBrand;
        price = carPrice;
        Color = carColor;
    }
}

class Program
{
    static void Main()
    {
        
        Car car = new Car("Toyota", 2500000, "Black");

        
        car.DisplayDetails();
    }
}
