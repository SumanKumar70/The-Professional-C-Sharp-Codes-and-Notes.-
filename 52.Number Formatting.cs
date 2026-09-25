using System;

class Program
{
    static void Main(string[]args)
    {
        double price = 12500.5678;

        Console.WriteLine("Currency: " + price.ToString("C"));
        Console.WriteLine("2 Decimal Places: " + price.ToString("F2"));
        Console.WriteLine("3 Decimal Places: " + price.ToString("F3"));
    }
}
