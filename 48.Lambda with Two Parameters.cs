using System;

class Program
{
    static void Main()
    {
        
        Func<int, int, int> larger = (a, b) => a > b ? a : b;

        int result = larger(10, 20);

        Console.WriteLine("Larger number = " + result);
    }
}
