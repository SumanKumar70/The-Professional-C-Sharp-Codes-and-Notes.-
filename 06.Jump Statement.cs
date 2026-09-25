using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i <= 20; i++)
        {
            
            if (i == 10)
            {
                continue;
            }

            
            if (i == 15)
            {
                break;
            }

            Console.WriteLine(i);
        }
    }
}
