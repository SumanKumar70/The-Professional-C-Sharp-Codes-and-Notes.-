using System;

class Program
{
    static void Main(string[]args)
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        // Arithmetic Operators
        Console.WriteLine("\n--- Arithmetic Operators ---");
        Console.WriteLine("Addition: " + (a + b));
        Console.WriteLine("Subtraction: " + (a - b));
        Console.WriteLine("Multiplication: " + (a * b));
        Console.WriteLine("Division: " + (a / b));
        Console.WriteLine("Modulus: " + (a % b));

        // Relational Operators
        Console.WriteLine("\n--- Relational Operators ---");
        Console.WriteLine("a == b: " + (a == b));
        Console.WriteLine("a != b: " + (a != b));
        Console.WriteLine("a > b: " + (a > b));
        Console.WriteLine("a < b: " + (a < b));
        Console.WriteLine("a >= b: " + (a >= b));
        Console.WriteLine("a <= b: " + (a <= b));

        // Logical Operators
        Console.WriteLine("\n--- Logical Operators ---");
        Console.WriteLine("(a > 0 && b > 0): " + (a > 0 && b > 0));
        Console.WriteLine("(a > 0 || b > 0): " + (a > 0 || b > 0));
        Console.WriteLine("!(a > b): " + !(a > b));

        // Assignment Operators
        Console.WriteLine("\n--- Assignment Operators ---");

        int x = a;

        x += b;
        Console.WriteLine("x += b: " + x);

        x -= b;
        Console.WriteLine("x -= b: " + x);

        x *= b;
        Console.WriteLine("x *= b: " + x);

        x /= b;
        Console.WriteLine("x /= b: " + x);

        x %= b;
        Console.WriteLine("x %= b: " + x);
    }
}
