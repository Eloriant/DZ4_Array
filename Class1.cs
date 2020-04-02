using System;
using System.Collections.Generic;
using System.Text;

namespace DZ4_Array
{
    public static class Class1
    {
        public static int[] revers(int[] a)
        {
            for (int i = 0; i < a.Length / 2; i++)
            {
                int tmp = a[i];
                a[i] = a[a.Length - 1 - i];
                a[a.Length - 1 - i] = tmp;
            }

            return a;
        }
    }
}
