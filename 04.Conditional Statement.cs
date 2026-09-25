using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter student's marks: ");
        int marks = Convert.ToInt32(Console.ReadLine());

        if (marks >= 90 && marks <= 100)
        {
            Console.WriteLine("Grade: A");
        }
        else if (marks >= 75 && marks <= 89)
        {
            Console.WriteLine("Grade: B");
        }
        else if (marks >= 60 && marks <= 74)
        {
            Console.WriteLine("Grade: C");
        }
        else if (marks >= 40 && marks <= 59)
        {
            Console.WriteLine("Grade: D");
        }
        else if (marks < 40)
        {
            Console.WriteLine("Grade: Fail");
        }
        else
        {
            Console.WriteLine("Invalid marks");
        }
    }
}
