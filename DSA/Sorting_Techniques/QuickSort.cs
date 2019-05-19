using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Sorting_Techniques
{
    public class QuickSort
    {
        private static int[] a;
        public static int[] SortAscending(int[] myArray)
        {
            a = myArray;
            QuickSortAscending(0, a.Length - 1);
            return a;
        }

        public static int[] SortDescending(int[] myArray)
        {
            a = myArray;
            QuickSortDescending(0, a.Length - 1);
            return a;
        }

        private static void QuickSortAscending(int left, int right)
        {
            if (right - left <= 0)
            {
                return;
            }
            else
            {
                int pivot = a[right];
                int partitionPoint = PartitionAscending(left, right, pivot);
                QuickSortAscending(left, partitionPoint - 1);
                QuickSortAscending(partitionPoint + 1, right);
            }
        }

        private static void QuickSortDescending(int left, int right)
        {
            if (right - left <= 0)
            {
                return;
            }
            else
            {
                int pivot = a[right];
                int partitionPoint = PartitionDescending(left, right, pivot);
                QuickSortDescending(left, partitionPoint - 1);
                QuickSortDescending(partitionPoint + 1, right);
            }
        }

        private static int PartitionAscending(int left, int right, int pivot)
        {
            int leftPointer = left - 1;
            int rightPointer = right;

            while (true)
            {
                while (a[++leftPointer] < pivot)
                {
                    //do nothing
                }

                while (rightPointer > 0 && a[--rightPointer] > pivot)
                {
                    //do nothing
                }

                if (leftPointer >= rightPointer)
                {
                    break;
                }
                else
                {                    
                    Swap(leftPointer, rightPointer);
                }
            }

            Swap(leftPointer, right);

            return leftPointer;
        }

        private static int PartitionDescending(int left, int right, int pivot)
        {
            int leftPointer = left - 1;
            int rightPointer = right;

            while (true)
            {
                while (a[++leftPointer] > pivot)
                {
                    //do nothing
                }

                while (rightPointer > 0 && a[--rightPointer] < pivot)
                {
                    //do nothing
                }

                if (leftPointer >= rightPointer)
                {
                    break;
                }
                else
                {
                    Swap(leftPointer, rightPointer);
                }
            }

            Swap(leftPointer, right);

            return leftPointer;
        }

        private static void Swap(int num1, int num2)
        {
            int temp = a[num1];
            a[num1] = a[num2];
            a[num2] = temp;
        }
    }
}
