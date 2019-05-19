using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Sorting_Techniques
{
    public class ShellSort
    {
        public static int[] SortAscending(int[] a)
        {
            int inner, outer;
            int valueToInsert;
            int interval = 1;            
            int i = 0;

            while (interval <= a.Length / 3)
            {
                interval = interval * 3 + 1;
            }

            while (interval > 0)
            {
                for (outer = interval; outer < a.Length; outer++)
                {
                    valueToInsert = a[outer];
                    inner = outer;

                    while (inner > interval - 1 && a[inner - interval]
                       >= valueToInsert)
                    {
                        a[inner] = a[inner - interval];
                        inner -= interval;                        
                    }

                    a[inner] = valueToInsert;             
                }

                interval = (interval - 1) / 3;
                i++;
            }

            return a;
        }
        public static int[] SortDescending(int[] a)
        {
            int inner, outer;
            int valueToInsert;
            int interval = 1;
            int i = 0;

            while (interval <= a.Length / 3)
            {
                interval = interval * 3 + 1;
            }

            while (interval > 0)
            {
                for (outer = interval; outer < a.Length; outer++)
                {
                    valueToInsert = a[outer];
                    inner = outer;

                    while (inner > interval - 1 && a[inner - interval]
                       <= valueToInsert)
                    {
                        a[inner] = a[inner - interval];
                        inner -= interval;
                    }

                    a[inner] = valueToInsert;
                }

                interval = (interval - 1) / 3;
                i++;
            }

            return a;
        }
    }
}
