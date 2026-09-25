using System;

class Box<T>
{
    public T Value;

    public Box(T value)
    {
        Value = value;
    }

    public void Display()
    {
        Console.WriteLine(Value);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Box<int> numberBox = new Box<int>(100);
        Box<string> nameBox = new Box<string>("Suman");

        numberBox.Display();
        nameBox.Display();
    }
}
