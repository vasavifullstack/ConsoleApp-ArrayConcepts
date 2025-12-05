using System;
using System.Collections;


namespace CsharpCourse_DataStructures
{
    class ArrayListExample
    {
        //ArrayList-dynamic collection.store objects of any type.
        //automatically resize when elements are added or removed.
        //non-generic -different data types,but it lacks type safety compared to List<T> HERE T-type.
        //Boxing and unboxing
        static void Main()
        {
            ArrayList data = new ArrayList();



            //object ---- int , decimal , bool , string


            //addthe numbers
            data.Add(10);
            data.Add(20);
            data.Add(30);
            data.Add(40);   // 10000

            data.Add("Apple");
            data.Add(true);  // add

            Console.WriteLine(data);

            //int            = object;      type cast  object into int 
            int secondValue = (int)data[1];   //step1 we converted   // GET


            data[3] = 10000;   // update
            data.Remove(30);  // remove



            Console.WriteLine(data);



        }
    }
}
