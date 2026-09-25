using System;

class Program
{
    static void Main(string[]args)
    {
        DateTime date = new DateTime(2026, 9, 24);

        Console.WriteLine(date.ToString("dd-MM-yyyy"));
        Console.WriteLine(date.ToString("dd/MM/yyyy"));
        Console.WriteLine(date.ToString("dd MMMM yyyy"));
    }
}
