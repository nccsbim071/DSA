using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Sorting_Techniques
{
    public class SelectionSort
    {
        public static int[] SortAscending(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                int smallestElementPosition = i;

                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < a[smallestElementPosition])
                    {
                        smallestElementPosition = j;
                    }
                }

                if (smallestElementPosition != i)
                {
                    int temp = a[i];
                    a[i] = a[smallestElementPosition];
                    a[smallestElementPosition] = temp;
                }
            }

            return a;
        }

        public static int[] SortDescending(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                int smallestElementPosition = i;

                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] > a[smallestElementPosition])
                    {
                        smallestElementPosition = j;
                    }
                }

                if (smallestElementPosition != i)
                {
                    int temp = a[i];
                    a[i] = a[smallestElementPosition];
                    a[smallestElementPosition] = temp;
                }
            }

            return a;
        }
    }
}
