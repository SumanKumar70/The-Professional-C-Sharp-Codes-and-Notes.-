using System;

class Program
{
    delegate void Operation(int a, int b);
    static void Add(int a, int b)
    {
        Console.WriteLine("Addition: " + (a + b));
    }

    static void Subtract(int a, int b)
    {
        Console.WriteLine("Subtraction: " + (a - b));
    }

  
    static void Multiply(int a, int b)
    {
        Console.WriteLine("Multiplication: " + (a * b));
    }

    static void Main(string[] args)
    {

        Operation operation = Add;
        
        operation += Subtract;
        operation += Multiply;

        operation(10, 5);
    }
}