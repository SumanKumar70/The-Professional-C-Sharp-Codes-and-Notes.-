using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 2, 8, 1, 4 };

        Array.Sort(numbers);

        Console.WriteLine("Sorted Array:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

      
        Array.Reverse(numbers);

        Console.WriteLine("\n\nReversed Array:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

       
        int searchNumber = 4;
        int index = Array.IndexOf(numbers, searchNumber);

        Console.WriteLine("\n\nIndex of " + searchNumber + " = " + index);
    }
}