using System;

struct Pair<T>
{
    public T First;
    public T Second;

    public Pair(T first, T second)
    {
        First = first;
        Second = second;
    }

    public void Display()
    {
        Console.WriteLine("First: " + First);
        Console.WriteLine("Second: " + Second);
    }
}

class Program
{
    static void Main()
    {
        Pair<int> numbers = new Pair<int>(10, 20);
        numbers.Display();

        Pair<string> names = new Pair<string>("Suman", "Kumar");
        names.Display();
    }
}
