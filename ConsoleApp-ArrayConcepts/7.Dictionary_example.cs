using System;
using System.Collections.Generic;

class Program1
{
    static void Main()
    {
        Dictionary<int, string> dict = new Dictionary<int, string>();

        dict.Add(1, "Apple");
        dict.Add(2, "Banana");
        

        dict[2] = "Yellow Banana"; // Update

        Console.WriteLine(dict.ContainsKey(1));       // true
        Console.WriteLine(dict.ContainsValue("Apple")); // false (updated)

        if (dict.TryGetValue(1, out string fruit))
        {
            Console.WriteLine("Value: " + fruit);
        }

        foreach (var pair in dict)
        {
            Console.WriteLine(pair.Key + " -> " + pair.Value);
        }

        dict.Remove(2);
        dict.Clear();
    }
}
