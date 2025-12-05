using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CsharpCourse_DataStructures
{
    //Array-collection of items with same datatype in a single block of memory
   //fixed size-so no added and remove methods.
   //fast accessing using index
   //default values= 0 for integers, null for objects.
    class ArrayExample
    {
        static void Main()
        {
            FixedSizeArray();
        }

        static void FixedSizeArray()
        {
            int[] numbers = new int[4]; //Fixed size

            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            //numbers[4] = 50; // runtime error expeciotn i.e. argement out of range excepitons..



            //numbers.ad

            //some scenerio
            numbers[0] = 50;  // you can do

            Console.WriteLine(numbers);


            int indexOf30 = Array.IndexOf(numbers, 30);   //

            Console.WriteLine(indexOf30);


            int SecondValue = numbers[1];   // No need the any cast...
            Console.WriteLine(SecondValue);
        }
    }
}



