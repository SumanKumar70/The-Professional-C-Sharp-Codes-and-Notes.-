using System;

class Program
{
    static void Main(string [] args)
    {
        string name = "Rahul";
        int age = 20;
        string city = "Delhi";

        Console.WriteLine("My name is " + name + ", I am " + age + " and I live in " + city);

        Console.WriteLine($"My name is {name}, I am {age} and I live in {city}");
    }
}
