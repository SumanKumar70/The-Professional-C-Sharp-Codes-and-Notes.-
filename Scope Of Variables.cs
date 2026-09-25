using System;

class Program
{
    static void Main(string[] args)
    {
        
        int mainNumber = 10;

        Console.WriteLine("Main variable: " + mainNumber);

        
        {
           
            int blockNumber = 20;

            Console.WriteLine("Main variable inside block: " + mainNumber);
            Console.WriteLine("Block variable: " + blockNumber);
        }
      
        Console.WriteLine("Main variable after block: " + mainNumber);

    
    }
}
