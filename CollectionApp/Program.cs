using System;
using System.Collections;

namespace CollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayList = new ArrayList();

            Console.WriteLine("Adding some numbers : ");
            arrayList.Add(35);
            arrayList.Add(23);
            arrayList.Add(37);
            arrayList.Add(2);
            Console.WriteLine("Number of elements : {0}", arrayList.Count);
            Console.WriteLine("Capacity of the arraylist is : {0}", arrayList.Capacity);

            foreach (var i in arrayList)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            Console.WriteLine("Print the arrays in sorted order: ");

            arrayList.Sort();
            foreach (var i in arrayList)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            arrayList.Insert(3, 23);

            Console.WriteLine("Array list after insertion: ");
            foreach (var i in arrayList)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.WriteLine("Index of 37 is : {0}", arrayList.IndexOf(37));
            Console.WriteLine("Number of elements : {0}", arrayList.Count);
            Console.WriteLine("Capacity of the arraylist is : {0}", arrayList.Capacity);
            arrayList.RemoveAt(2);
            Console.WriteLine("Array list after remove: ");
            foreach (var i in arrayList)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
