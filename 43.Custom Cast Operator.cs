using System;

class Student
{
    public int Age;

    public Student(int age)
    {
        Age = age;
    }

    
    public static explicit operator int(Student student)
    {
        return student.Age;
    }
}

class Program
{
    static void Main(string[]args)
    {
        Student student = new Student(20);

        
        int age = (int)student;

        Console.WriteLine("Student Age: " + age);
    }
}
