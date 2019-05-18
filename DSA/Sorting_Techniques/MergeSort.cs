using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Sorting_Techniques
{
    public class MergeSort
    {   
        public static int[] SortAscending(int[] a)
        {
            if (a.Length == 1)
            {
                return a;
            }
            else
            {
                int midPoint = a.Length / 2;

                int[] firstHalf = new int[midPoint];
                for (int i = 0; i < midPoint; i++)
                {
                    firstHalf[i] = a[i];
                }

                int[] sortedFirstHalf = SortAscending(firstHalf);

                int[] secondHalf = new int[a.Length - midPoint];

                for (int i = midPoint, j = 0; i < a.Length; i++, j++)
                {
                    secondHalf[j] = a[i];
                }

                int[] sortedSecondHalf = SortAscending(secondHalf);

                return MergeAscending(sortedFirstHalf, sortedSecondHalf);
            }
        }

        private static int[] MergeAscending(int[] a, int[] b)
        {
            int totalLength = a.Length + b.Length;
            int[] temp = new int[totalLength];
            int i, j, k = 0;

            for (i = 0, j = 0; i < a.Length && j < b.Length; k += 1)
            {
                if (a[i] <= b[j])
                {
                    temp[k] = a[i];
                    i += 1;
                }
                else
                {
                    temp[k] = b[j];
                    j += 1;
                }
            }

            for (int l = i; l < a.Length; l++)
            {
                temp[k] = a[l];
                k += 1;
            }

            for (int l = j; l < b.Length; l++)
            {
                temp[k] = b[l];
                k += 1;
            }

            return temp;
        }

        public static int[] SortDescending(int[] a)
        {
            if (a.Length == 1)
            {
                return a;
            }
            else
            {
                int midPoint = a.Length / 2;

                int[] firstHalf = new int[midPoint];
                for (int i = 0; i < midPoint; i++)
                {
                    firstHalf[i] = a[i];
                }

                int[] sortedFirstHalf = SortDescending(firstHalf);

                int[] secondHalf = new int[a.Length - midPoint];

                for (int i = midPoint, j = 0; i < a.Length; i++, j++)
                {
                    secondHalf[j] = a[i];
                }

                int[] sortedSecondHalf = SortDescending(secondHalf);

                return MergeDescending(sortedFirstHalf, sortedSecondHalf);
            }
        }

        private static int[] MergeDescending(int[] a, int[] b)
        {
            int totalLength = a.Length + b.Length;
            int[] temp = new int[totalLength];
            int i, j, k = 0;

            for (i = 0, j = 0; i < a.Length && j < b.Length; k += 1)
            {
                if (a[i] >= b[j])
                {
                    temp[k] = a[i];
                    i += 1;
                }
                else
                {
                    temp[k] = b[j];
                    j += 1;
                }
            }

            for (int l = i; l < a.Length; l++)
            {
                temp[k] = a[l];
                k += 1;
            }

            for (int l = j; l < b.Length; l++)
            {
                temp[k] = b[l];
                k += 1;
            }

            return temp;
        }
    }
}
