using System;

static class Calculator
{ 
    public static int Add(int number1, int number2)
    {
        return number1 + number2;
    }

    
    public static int Subtract(int number1, int number2)
    {
        return number1 - number2;
    }
}

class Program
{
    static void Main()
    {
        
        int sum = Calculator.Add(10, 5);
        int difference = Calculator.Subtract(10, 5);

        Console.WriteLine("Addition: " + sum);
        Console.WriteLine("Subtraction: " + difference);
    }
}