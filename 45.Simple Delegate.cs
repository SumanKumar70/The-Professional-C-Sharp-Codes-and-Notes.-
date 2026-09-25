using System;

class Program
{
   
    delegate void MyDelegate();

    static void SayHello()
    {
        Console.WriteLine("Hello, Welcome to C#!");
    }

    static void Main(string[]args)
    {
       
        MyDelegate del = SayHello;
        del();
    }
}