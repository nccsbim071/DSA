using System;
using DSA.Sorting_Techniques;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Bubble Sort
            //int[] a = new int[] { 9, 3, 2, 1, 0 };
            //Console.WriteLine($"Input Array: {String.Join(",", a)}");
            //a = BubbleSort.SortAscending(a);
            //Console.WriteLine($"Output Array: {String.Join(",", a)}");

            //int[] a = new int[] { 15, 1, 18, 3, 45 };
            //Console.WriteLine($"Input Array: {String.Join(",", a)}");
            //a = BubbleSort.SortDescending(a);
            //Console.WriteLine($"Output Array: {String.Join(",", a)}");
            #endregion

            #region Insertion Sort
            //int[] a = new int[] { 15, 1, 18, 3, 45 };
            //Console.WriteLine($"Input: Array: {String.Join(",", a)}");
            //a = InsertionSort.SortAscending(a);
            //Console.WriteLine($"Output: Array: {String.Join(",", a)}");

            //int[] a1 = new int[] { 15, 1, 18, 3, 45 };
            //Console.WriteLine($"Input Array: {String.Join(",", a1)}");
            //a1 =  InsertionSort.SortDescending(a1);
            //Console.WriteLine($"Output Array: {String.Join(",", a1)}");
            #endregion

            #region Selection Sort
            //int[] a = new int[] { 15, 9, 23, 10, 6 };
            //Console.WriteLine($"Sort Ascending");
            //Console.WriteLine($"Input Array: {String.Join(",", a)}");
            //a = SelectionSort.SortAscending(a);
            //Console.WriteLine($"Output Array: {String.Join(",", a)}");

            //a = new int[] { 15, 9, 23, 10, 6 };
            //Console.WriteLine("\n\nSort Descending");
            //Console.WriteLine($"Input Array: {String.Join(",", a)}");
            //a = SelectionSort.SortDescending(a);
            //Console.WriteLine($"Output Array: {String.Join(",", a)}");
            #endregion

            #region Merge Sort
            //int[] a = new int[] { 6, 3, 4, 5, 1 };
            //Console.WriteLine("Ascending Sort");
            //Console.WriteLine($"Input Array: {String.Join(",",a)}");
            //a = MergeSort.SortAscending(a);
            //Console.WriteLine($"Output Array: {String.Join(",", a)}");

            //a = new int[] { 6, 3, 4, 5, 1 };
            //Console.WriteLine("Descending Sort");
            //Console.WriteLine($"Input Array: {String.Join(",", a)}");
            //a = MergeSort.SortDescending(a);
            //Console.WriteLine($"Output Array: {String.Join(",", a)}");
            #endregion

            #region Shell Sort
            //int[] a = new int[] { 4, 6, 3, 2, 1, 9, 7 };
            //Console.WriteLine($"Input Array: {String.Join(",", a)}");
            //a = ShellSort.SortAscending(a);
            //Console.WriteLine($"Output Array: {String.Join(",", a)}");
            //Console.WriteLine("\n\n");
            //a = new int[] { 4, 6, 3, 2, 1, 9, 7 };
            //Console.WriteLine($"Input Array: {String.Join(",", a)}");
            //a = ShellSort.SortDescending(a);
            //Console.WriteLine($"Output Array: {String.Join(",", a)}");
            #endregion

            #region Quick Sort 
            int[] a = new int[] { 4, 6, 3, 2, 1, 9, 7 };
            Console.WriteLine($"Input Array: {String.Join(",",a)}");
            a = QuickSort.SortAscending(a);
            Console.WriteLine($"Output Array: {String.Join(",", a)}");

            a = new int[] { 4, 6, 3, 2, 1, 9, 7 };
            Console.WriteLine($"\n\nInput Array: {String.Join(",", a)}");
            a = QuickSort.SortDescending(a);
            Console.WriteLine($"Output Array: {String.Join(",", a)}");
            #endregion

            Console.ReadKey();
        }

    }
}
