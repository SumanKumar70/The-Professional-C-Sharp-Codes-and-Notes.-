using System;

class Student
{
    public string Name;

    public Student(string name)
    {
        Name = name;
    }
}

class Program
{
    static void Main(string[]args)
    {
        Student student = new Student("Rahul");

        Console.WriteLine(student.Name);

        student = null;

        GC.Collect();

        Console.WriteLine("Garbage collection requested");
    }
}
