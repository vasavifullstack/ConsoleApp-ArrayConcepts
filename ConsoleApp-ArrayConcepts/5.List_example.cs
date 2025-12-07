using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> list = new List<int>();

        list.Add(10);
        list.AddRange(new int[] { 20, 30, 40 });

        list.Insert(1, 15);
        list.InsertRange(3, new int[] { 25, 35 });

        list.Remove(20);
        list.RemoveAt(2);
        list.RemoveAll(x => x > 30);

        bool found = list.Contains(10);
        int index = list.IndexOf(15);

        list.Sort();
        list.Reverse();

        list.ForEach(x => Console.WriteLine(x));
    }
}

