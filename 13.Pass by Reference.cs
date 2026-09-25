using System;

class Program
{
    
    static void ChangeNumber(ref int number)
    {
        number = 100;
    }

    static void Main(string[]args)
    {
        int number = 50;

        Console.WriteLine("Before method call: " + number);

        ChangeNumber(ref number);

        Console.WriteLine("After method call: " + number);
    }
}
