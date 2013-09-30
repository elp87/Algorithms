using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elp87.Algorithms
{
    public static partial class Sort
    {
        public static int[] InsertionSort(int[] A)
        {
            for (int i = 1; i < A.Length; i++)
            {
                int key = A[i];
                int j = i - 1;
                while (j >= 0 && A[j] > key)
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                }
                A[j + 1] = key;
            }
            return A;
        }
    }
}
