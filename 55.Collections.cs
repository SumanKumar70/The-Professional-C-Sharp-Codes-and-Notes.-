using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[]args)
    {
        // 1. List
        List<int> list = new List<int> { 10, 20, 30 };
        list.Add(40);

        Console.WriteLine("List:");
        foreach (int n in list)
            Console.WriteLine(n);


        // 2. Queue
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("A");
        queue.Enqueue("B");
        queue.Enqueue("C");

        Console.WriteLine("\nQueue:");
        Console.WriteLine(queue.Dequeue());


        // 3. Stack
        Stack<string> stack = new Stack<string>();
        stack.Push("Page1");
        stack.Push("Page2");
        stack.Push("Page3");

        Console.WriteLine("\nStack:");
        Console.WriteLine(stack.Pop());


        // 4. LinkedList
        LinkedList<int> linkedList = new LinkedList<int>();
        linkedList.AddLast(10);
        linkedList.AddLast(20);
        linkedList.AddFirst(5);

        Console.WriteLine("\nLinkedList:");
        foreach (int n in linkedList)
            Console.WriteLine(n);


        // 5. SortedList
        SortedList<int, string> sortedList = new SortedList<int, string>();
        sortedList.Add(3, "C");
        sortedList.Add(1, "A");
        sortedList.Add(2, "B");

        Console.WriteLine("\nSortedList:");
        foreach (var item in sortedList)
            Console.WriteLine(item.Key + " = " + item.Value);


        // 6. Dictionary
        Dictionary<int, string> students = new Dictionary<int, string>();
        students.Add(101, "Rahul");
        students.Add(102, "Amit");
        students.Add(103, "Priya");

        Console.WriteLine("\nDictionary:");
        foreach (var student in students)
            Console.WriteLine(student.Key + " = " + student.Value);


        // 7. HashSet
        HashSet<int> set = new HashSet<int> { 10, 20, 30, 30 };

        Console.WriteLine("\nHashSet:");
        foreach (int n in set)
            Console.WriteLine(n);


        // 8. BitArray
        BitArray bits = new BitArray(4);

        bits[0] = true;
        bits[1] = false;
        bits[2] = true;
        bits[3] = true;

        Console.WriteLine("\nBitArray:");
        for (int i = 0; i < bits.Length; i++)
            Console.WriteLine(bits[i]);
    }
}