using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Sorting_Techniques
{
    public class InsertionSort
    {
        public static int[] SortAscending(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                int valueToInsert = a[i];
                int holePosition = i;

                while (holePosition > 0 && a[i - 1] > valueToInsert)
                {
                    a[holePosition] = a[holePosition - 1];
                    holePosition--;
                }

                if (holePosition != i)
                {
                    a[holePosition] = valueToInsert;
                }
            }

            return a;
        }

        public static int[] SortDescending(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                int valueToInsert = a[i];
                int holePosition = i;

                while (holePosition > 0 && a[holePosition - 1] < valueToInsert)
                {
                    a[holePosition] = a[holePosition - 1];
                    holePosition--;
                }

                if (holePosition != i)
                {
                    a[holePosition] = valueToInsert;
                }
            }

            return a;
        }
    }
}
