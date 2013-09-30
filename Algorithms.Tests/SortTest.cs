using elp87.Algorithms;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace elp87.Algorithms.Tests
{
    [TestClass]
    public class SortTest
    {
        [TestMethod]
        public void TestInsertionSort()
        {
            int[][] expA = new int[][] { new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 26, 31, 41, 41, 58, 59 } };

            int[][] A = new int[][] { new int[] { 5, 2, 4, 6, 1, 3 }, new int[] { 31, 41, 59, 26, 41, 58 } };

            for (int i = 0; i < A.Length; i++)
            {
                int[] retA = Sort.InsertionSort(A[i]);
                CollectionAssert.AreEqual(expA[i], retA);
            }
        }
    }
}
