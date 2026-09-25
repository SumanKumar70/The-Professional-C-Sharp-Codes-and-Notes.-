using System;

interface IPrinter<T>
{
    void Print(T value);
}

class Printer<T> : IPrinter<T>
{
    public void Print(T value)
    {
        Console.WriteLine(value);
    }
}

class Program
{
    static void Main()
    {
        Printer<int> numberPrinter = new Printer<int>();
        numberPrinter.Print(100);

        Printer<string> textPrinter = new Printer<string>();
        textPrinter.Print("Hello");
    }
}
