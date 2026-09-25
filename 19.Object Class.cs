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

    public override string ToString()
    {
        return "Name: " + Name + ", Age: " + Age;
    }
}

class Program
{
    static void Main()
    {
      
        Student student = new Student("Rahul", 20);

        object obj = student;    
        
        Console.WriteLine(obj.ToString());
    }
}
