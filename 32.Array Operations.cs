using System;

class Program
{
    static void Main(string[]args)
    {
        int[,] numbers =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        int sum = 0;

        
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(numbers[i, j] + " ");
                sum += numbers[i, j];
            }

            Console.WriteLine();
        }

        Console.WriteLine("Sum = " + sum);
    }
}