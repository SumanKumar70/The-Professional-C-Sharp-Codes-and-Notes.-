using System;

class Program
{
    static void Main()
    {
        
        int number = 10;

        // Boxing: int → object
        object obj = number;

        // Unboxing: object → int
        int result = (int)obj;

       
        Console.WriteLine("Original int value: " + number);
        Console.WriteLine("After boxing: " + obj);
        Console.WriteLine("After unboxing: " + result);
    }
}