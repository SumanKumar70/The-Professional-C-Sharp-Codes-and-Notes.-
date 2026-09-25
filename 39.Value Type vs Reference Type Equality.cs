using System;

class Student
{
    public string Name;
    public int Age;
}

class Program
{
    static void Main()
    {
        
        int a = 10;
        int b = 10;

        Console.WriteLine("Value Type:");
        Console.WriteLine(a == b);


        
        Student student1 = new Student();
        student1.Name = "Rahul";
        student1.Age = 20;

        Student student2 = new Student();
        student2.Name = "Rahul";
        student2.Age = 20;

        Console.WriteLine("\nReference Type:");
        Console.WriteLine(student1 == student2);
    }
}
