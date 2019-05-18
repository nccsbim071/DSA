using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Sorting_Techniques
{
    public class BubbleSort
    {
        public static int[] SortAscending(int[] a)
        {
            int noOfIterations = 0;
            int tmpLength = a.Length;
            for (int i = 0; i < a.Length; i++)
            {
                bool swapped = false;

                for (int j = 0; j < tmpLength - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;

                        swapped = true;
                    }

                    noOfIterations += 1;
                }

                noOfIterations += 1;

                tmpLength -= 1;

                if (!swapped)
                {
                    break;
                }
            }

            return a;
        }
        public static int[] SortDescending(int[] a)
        {
            int noOfIterations = 0;
            int tmpLength = a.Length;
            for (int i = 0; i < a.Length; i++)
            {
                bool swapped = false;

                for (int j = 0; j < tmpLength - 1; j++)
                {
                    if (a[j] < a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;

                        swapped = true;
                    }

                    noOfIterations += 1;
                }

                noOfIterations += 1;

                tmpLength -= 1;

                if (!swapped)
                {
                    break;
                }
            }

            return a;
        }
    }
}
