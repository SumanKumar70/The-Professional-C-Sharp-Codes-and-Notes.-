using System;

class Student
{
    
    public string Name;
    public int Age;

    
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Student student = new Student("Rahul", 20);

       
        Console.WriteLine("Name: " + student.Name);
        Console.WriteLine("Age: " + student.Age);
    }
}
