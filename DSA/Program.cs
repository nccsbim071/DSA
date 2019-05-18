using System;
using DSA.Sorting_Techniques;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] a = new int[] { 9, 3, 2, 1, 0 };
            //Console.WriteLine($"Input Array: {String.Join(",", a)}");
            //a = BubbleSort.SortAscending(a);
            //Console.WriteLine($"Output Array: {String.Join(",", a)}");

            //int[] a = new int[] { 15, 1, 18, 3, 45 };
            //Console.WriteLine($"Input Array: {String.Join(",", a)}");
            //a = BubbleSort.SortDescending(a);
            //Console.WriteLine($"Output Array: {String.Join(",", a)}");

            //int[] a = new int[] { 15, 1, 18, 3, 45 };
            //Console.WriteLine($"Input: Array: {String.Join(",", a)}");
            //a = InsertionSort.SortAscending(a);
            //Console.WriteLine($"Output: Array: {String.Join(",", a)}");

            int[] a1 = new int[] { 15, 1, 18, 3, 45 };
            Console.WriteLine($"Input Array: {String.Join(",", a1)}");
            a1 =  InsertionSort.SortDescending(a1);
            Console.WriteLine($"Output Array: {String.Join(",", a1)}");

            Console.ReadKey();
        }

    }
}
