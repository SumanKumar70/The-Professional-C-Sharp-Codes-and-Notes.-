using System;


class Person
{
    public string Name;

    public void DisplayName()
    {
        Console.WriteLine("Name: " + Name);
    }
}


class Student : Person
{
}

class Program
{
    static void Main()
    {
   
        Student student = new Student();

        student.Name = "Rahul";

        student.DisplayName();
    }
}
