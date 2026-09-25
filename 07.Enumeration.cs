using System;

class Program
{
    enum Days
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number (1-7): ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number >= 1 && number <= 7)
        {
            Days day = (Days)number;
            Console.WriteLine("Day: " + day);
        }
        else
        {
            Console.WriteLine("Invalid number. Please enter 1-7.");
        }
    }
}
