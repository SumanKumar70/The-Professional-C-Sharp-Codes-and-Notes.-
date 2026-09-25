using System;

class Parent
{
    public int publicNumber = 10;
    private int privateNumber = 20;
    protected int protectedNumber = 30;
}

class Child : Parent
{
    public void Display()
    {
        Console.WriteLine("Public: " + publicNumber);

        Console.WriteLine("Protected: " + protectedNumber);

    }
}

class Program
{
    static void Main()
    {
        Child child = new Child();

        child.Display();

        Console.WriteLine("Public from Main: " + child.publicNumber);

    }
}