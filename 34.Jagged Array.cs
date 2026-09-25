using System;

class Program
{
    static void Main(string[]args)
    {
        
        int[][] numbers = new int[3][];

        
        numbers[0] = new int[2];
        numbers[1] = new int[3];
        numbers[2] = new int[4];

    
        numbers[0][0] = 1;
        numbers[0][1] = 2;

        numbers[1][0] = 3;
        numbers[1][1] = 4;
        numbers[1][2] = 5;

        numbers[2][0] = 6;
        numbers[2][1] = 7;
        numbers[2][2] = 8;
        numbers[2][3] = 9;

       
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers[i].Length; j++)
            {
                Console.Write(numbers[i][j] + " ");
            }

            Console.WriteLine();
        }
    }
}
