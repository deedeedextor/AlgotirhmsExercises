using System;
using System.Collections.Generic;

namespace MergeSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            MergeSortedArrays(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 });
        }

        private static void MergeSortedArrays(int[] arrOne, int[] arrTwo)
        {
            var sortedArray = new List<int>();

            sortedArray.AddRange(arrOne);
            sortedArray.AddRange(arrTwo);

            Console.WriteLine(string.Join(", ", sortedArray));
        }
    }
}
