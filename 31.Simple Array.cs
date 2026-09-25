using System;
namespace SimpleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of integers
            int[] numbers = new int[5];
            // Assign values to the array
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;
            // Print the values of the array
            Console.WriteLine("The values in the array are:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}