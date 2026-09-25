using System;
using System.Collections;

class Program
{
    static void Main(string[]args)
    {
        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 1, 2, 3 };

        bool result = StructuralComparisons
            .StructuralEqualityComparer
            .Equals(array1, array2);

        Console.WriteLine("Are arrays structurally equal? " + result);
    }
}
