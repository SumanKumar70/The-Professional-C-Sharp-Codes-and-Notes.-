using System;

class Person
{
    public string Name;

    public Person(string name)
    {
        Name = name;
    }
}

class Student : Person
{
    public int RollNo;

    public Student(string name, int rollNo)
        : base(name)
    {
        RollNo = rollNo;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Roll No: " + RollNo);
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student("Rahul", 101);

        student.Display();
    }
}
