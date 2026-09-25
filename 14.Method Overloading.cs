using System;

class Program
{
   
    static int Add(int number1, int number2)
    {
        return number1 + number2;
    }

   
    static int Add(int number1, int number2, int number3)
    {
        return number1 + number2 + number3;
    }

   
    static double Add(double number1, double number2)
    {
        return number1 + number2;
    }

    static void Main()
    {
        int result1 = Add(10, 20);
        int result2 = Add(10, 20, 30);
        double result3 = Add(10.5, 20.5);

        Console.WriteLine("Add(int, int): " + result1);
        Console.WriteLine("Add(int, int, int): " + result2);
        Console.WriteLine("Add(double, double): " + result3);
    }
}
