using System;

namespace StudentProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter student's name: ");
            string name = Console.ReadLine();

            System.Console.Write("Enter student's age: ");
            int age = Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Student Name: " + name);
            System.Console.WriteLine("Student Age: " + age);
        }
    }
}