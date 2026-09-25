using System;

class Program
{
    static void Main(string[]args)
    {
        int number = 10;
        double decimalNumber = 20.75;
        float floatNumber = 15.5f;

        // int → double
        double result1 = number;
        Console.WriteLine("int → double: " + result1);

        // double → int
        int result2 = (int)decimalNumber;
        Console.WriteLine("double → int: " + result2);

        // int → string
        string result3 = number.ToString();
        Console.WriteLine("int → string: " + result3);

        // string → int
        string text = "50";
        int result4 = Convert.ToInt32(text);
        Console.WriteLine("string → int: " + result4);

        // float
        Console.WriteLine("Float value: " + floatNumber);
    }
}