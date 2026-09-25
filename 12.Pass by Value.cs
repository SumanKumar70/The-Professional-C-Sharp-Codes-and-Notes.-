using System;

class Program
{
  
    static void ChangeNumber(int number)
    {
        number = 100;
        Console.WriteLine("Inside method: " + number);
    }

    static void Main(string[]args)
    {
        int number = 50;

        Console.WriteLine("Before method call: " + number);

        ChangeNumber(number);

        Console.WriteLine("After method call: " + number);
    }
}