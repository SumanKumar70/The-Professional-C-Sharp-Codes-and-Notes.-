using System;
using System.Text;

class Program
{
    static void Main(string[]args)
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("Welcome ");
        sb.Append("to ");
        sb.Append("C# ");
        sb.Append("Programming");

        Console.WriteLine(sb);
    }
}
