using System;

class College
{
    
    public static string CollegeName;

    
    static College()
    {
        CollegeName = "ABC College";
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("College Name: " + College.CollegeName);
    }
}
