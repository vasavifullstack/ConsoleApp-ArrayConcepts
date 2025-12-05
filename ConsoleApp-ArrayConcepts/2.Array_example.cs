using System;

namespace ArrayFullConcepts
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== ARRAY CONCEPTS & METHODS ===\n");

         
            // 1. DECLARATION
            int[] numbers = new int[4];     // fixed size array
            int[] values = { 10, 20, 30 };  // array with values

            // 2. INSERTING VALUES

            numbers[0] = 40;
            numbers[1] = 10;
            numbers[2] = 30;
            numbers[3] = 20;

            Console.WriteLine("Original Numbers: " + string.Join(", ", numbers));

 
            // 3. ACCESSING ELEMENTS
      
            int first = numbers[0];
            int third = numbers[2];

            Console.WriteLine("\nFirst Element: " + first);
            Console.WriteLine("Third Element: " + third);

       
            // 4. IMPORTANT PROPERTIES
    
            Console.WriteLine("\nLength of array: " + numbers.Length);
            Console.WriteLine("Rank (dimensions): " + numbers.Rank);

            // 5. ARRAY METHODS

            // A) IndexOf
            int index30 = Array.IndexOf(numbers, 30);
            Console.WriteLine("\nIndexOf 30: " + index30);

            // B) LastIndexOf
            int[] nums2 = { 10, 20, 30, 20, 40 };
            Console.WriteLine("LastIndexOf 20: " + Array.LastIndexOf(nums2, 20));

            // C) Sort
            Array.Sort(numbers);
            Console.WriteLine("\nSorted: " + string.Join(", ", numbers));

            // D) Reverse
            Array.Reverse(numbers);
            Console.WriteLine("Reversed: " + string.Join(", ", numbers));

            // E) Clear (sets values to default)
            int[] temp = { 1, 2, 3, 4 };
            Array.Clear(temp, 1, 2); // clear index 1 & 2
            Console.WriteLine("\nClear Example: " + string.Join(", ", temp));

            // F) Copy
            int[] src = { 10, 20, 30 };
            int[] dest = new int[5];
            Array.Copy(src, dest, src.Length);
            Console.WriteLine("Copy: " + string.Join(", ", dest));

            // G) CopyTo (instance method)
            int[] c1 = { 1, 2, 3 };
            int[] c2 = new int[5];
            c1.CopyTo(c2, 1);
            Console.WriteLine("CopyTo: " + string.Join(", ", c2));

            // H) Exists (condition check)
            bool exists = Array.Exists(numbers, x => x > 25);
            Console.WriteLine("\nExists > 25: " + exists);

            // I) Find (first match)
            int findValue = Array.Find(numbers, x => x > 10);
            Console.WriteLine("Find > 10: " + findValue);

            // J) FindAll (all matches)
            int[] findAll = Array.FindAll(numbers, x => x > 10);
            Console.WriteLine("FindAll > 10: " + string.Join(", ", findAll));

            // K) FindIndex
            int findIndex = Array.FindIndex(numbers, x => x == 20);
            Console.WriteLine("FindIndex of 20: " + findIndex);

            // L) FindLast
            int findLast = Array.FindLast(nums2, x => x == 20);
            Console.WriteLine("FindLast of 20: " + findLast);

            // M) Resize
            int[] resizeArr = { 5, 10, 15 };
            Array.Resize(ref resizeArr, 5);
            Console.WriteLine("\nResized array (length 5): " +
                              string.Join(", ", resizeArr));

            // N) ConvertAll (convert types)
            string[] strNumbers = { "1", "2", "3" };
            int[] converted = Array.ConvertAll(strNumbers, int.Parse);
            Console.WriteLine("ConvertAll (string → int): " +
                              string.Join(", ", converted));

       
            // 6. MULTI-DIMENSIONAL ARRAY
            int[,] matrix = {
                {1, 2, 3},
                {4, 5, 6}
            };

            Console.WriteLine("\nMatrix Value (1,2): " + matrix[1, 2]); // 6

       
            // 7. JAGGED ARRAY
            int[][] jagged = new int[2][];
            jagged[0] = new int[] { 10, 20 };
            jagged[1] = new int[] { 30, 40, 50 };

            Console.WriteLine("\nJagged[1][2]: " + jagged[1][2]); // 50

            Console.WriteLine("\n=== END OF ARRAY DEMO ===");
        }
    }
}
