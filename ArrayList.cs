using System;
using System.Collections;

namespace PT_example
{
    class ArrayListDemo
    {
        public static void _7Main()
        {
            ArrayList A = new ArrayList();

            A.Add("A");
            A.Add("S");
            A.Add("P");

            Console.WriteLine("Number of Elements: " + A.Count);

            A.Remove("A");

            Console.WriteLine("After Removing A:");
            foreach (string str in A)
            {
                Console.WriteLine(str + " ");
            }

            Console.WriteLine();

            ArrayList al1 = new ArrayList();
            ArrayList al2 = new ArrayList(10);

            int[] intArr = new int[10];
            ArrayList al3 = new ArrayList(intArr);

            ArrayList myArrayList = new ArrayList();
            myArrayList.Capacity = 10;

            int[] intArr2 = { 2, 3, 4, 5 };

            myArrayList.Add(1);
            myArrayList.AddRange(intArr2);

            Console.WriteLine("Capacity: " + myArrayList.Capacity);

            myArrayList.Remove(1);
            myArrayList.RemoveRange(1, 2);
            myArrayList.Insert(1, 3);

            myArrayList.InsertRange(0, intArr);

            Console.WriteLine("ArrayList Elements:");
            foreach (object elem in myArrayList)
            {
                Console.WriteLine(elem);
            }

            Console.WriteLine();

            ArrayList al = new ArrayList();

            Console.WriteLine("Initial number of elements: " + al.Count);

            Console.WriteLine("Adding 6 elements");

            al.Add('C');
            al.Add('A');
            al.Add('E');
            al.Add('B');
            al.Add('D');
            al.Add('F');

            Console.WriteLine("Number of elements: " + al.Count);

            Console.WriteLine("Removing 2 elements");

            al.Remove('F');
            al.Remove('A');

            Console.WriteLine("Number of elements: " + al.Count);

            Console.ReadKey();
        }
    }
}