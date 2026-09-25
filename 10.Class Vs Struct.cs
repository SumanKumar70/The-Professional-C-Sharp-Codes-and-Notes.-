using System;


class Student
{
    public string Name;
    public int Age;
}

struct StudentStruct
{
    public string Name;
    public int Age;
}

class Program
{
    static void Main(string[] args)
    {
        
        Student student1 = new Student();
        student1.Name = "Rahul";
        student1.Age = 20;

        Student student2 = student1;

        
        StudentStruct studentStruct1 = new StudentStruct();
        studentStruct1.Name = "Amit";
        studentStruct1.Age = 21;

        StudentStruct studentStruct2 = studentStruct1;

       
        student2.Name = "Raj";
        student2.Age = 25;

        
        studentStruct2.Name = "Vijay";
        studentStruct2.Age = 30;

      
        Console.WriteLine("----- Class -----");
        Console.WriteLine("Student1 Name: " + student1.Name);
        Console.WriteLine("Student1 Age: " + student1.Age);

        Console.WriteLine("Student2 Name: " + student2.Name);
        Console.WriteLine("Student2 Age: " + student2.Age);

       
        Console.WriteLine("\n----- Struct -----");
        Console.WriteLine("StudentStruct1 Name: " + studentStruct1.Name);
        Console.WriteLine("StudentStruct1 Age: " + studentStruct1.Age);

        Console.WriteLine("StudentStruct2 Name: " + studentStruct2.Name);
        Console.WriteLine("StudentStruct2 Age: " + studentStruct2.Age);
    }
}
