using System;

namespace elp87.Algorithms
{
    public static partial class Sort
    {
        public static void MergeSort(int[] array)
        {
            int lb = 0;
            int rb = array.Length - 1;
            Sort.MergeSort(array, lb, rb);
        }

        private static void MergeSort(int[] array, int lb, int rb)
        {
            int split;
            if (lb < rb)
            {
                split = (lb + rb) / 2;
                MergeSort(array, lb, split);
                MergeSort(array, split + 1, rb);
                Merge(array, lb, split, rb);
            }
        }

        private static void Merge(int[] array, int left, int center, int right)
        {
            int i, j;
            int n1 = center - left + 1;
            int n2 = right - center;
            int[] L = new int[n1 + 1];
            int[] R = new int[n2 + 1];
            for (i = 0; i < n1; i++)
            {
                L[i] = array[left + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = array[center + j + 1];
            }
            L[L.Length - 1] = Int32.MaxValue;
            R[R.Length - 1] = Int32.MaxValue;
            i = 0;
            j = 0;
            for (int k = left; k <= right; k++)
            {
                if (L[i] <= R[j])
                {
                    array[k] = L[i];
                    i++;
                }
                else
                {
                    array[k] = R[j];
                    j++;
                }
            }
        }
    }
}
