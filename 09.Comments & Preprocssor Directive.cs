#define SHOW_FORMULA

using System;

class Program
{
    static void Main()
    {
        
        double rectangleLength = 10;
        double rectangleWidth = 5;

       
        double rectangleArea = rectangleLength * rectangleWidth;

        Console.WriteLine("Length: " + rectangleLength);
        Console.WriteLine("Width: " + rectangleWidth);
        Console.WriteLine("Area: " + rectangleArea);

       
#if SHOW_FORMULA
        Console.WriteLine("Formula: Area = Length × Width");
#endif
    }
}
