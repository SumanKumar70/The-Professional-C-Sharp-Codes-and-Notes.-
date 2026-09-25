using System;

class Program
{
    static void Main(string[]args)
    {
        
        Func<int, int> square = number => number * number;

        int result = square(5);

        Console.WriteLine("Square = " + result);
    }
}
