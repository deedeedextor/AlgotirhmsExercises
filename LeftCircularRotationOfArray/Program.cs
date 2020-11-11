using System;
using System.Globalization;

namespace RightLeftCircularRotationOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            PerformRightCircularRotationInAnArray(new int[6] { 1, 2, 3, 4, 5, 6 });
            PerformLeftCircularRotationInAnArray(new int[6] { 1, 2, 3, 4, 5, 6 });
        }

        private static void PerformLeftCircularRotationInAnArray(int[] array)
        {
            int temp;

            for (int i = array.Length - 1; i > 0 ; i--)
            {
                temp = array[array.Length - 1];
                array[array.Length - 1] = array[i - 1];
                array[i - 1] = temp;
            }

            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        private static void PerformRightCircularRotationInAnArray(int[] array)
        {
            int temp;

            for (int i = 0; i < array.Length - 1; i++)
            {
                temp = array[0];
                array[0] = array[i + 1];
                array[i + 1] = temp;
            }

            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
