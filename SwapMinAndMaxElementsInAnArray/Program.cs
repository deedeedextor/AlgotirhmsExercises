using System;

namespace SwapMinAndMaxElementsInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            SwapMinAndMaxElements(new int[] { 1, 2, 3 });
            SwapMinAndMaxElements(new int[] { 1, 2, 4, 3, 5 });
        }

        private static void SwapMinAndMaxElements(int[] array)
        {
            Array.Sort(array);

            int min = 0;
            int max = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[min] > array[i])
                {
                    min = i;
                }
                if (array[max] < array[i])
                {
                    max = i;
                }
            }

            int temp = array[min];
            array[min] = array[max];
            array[max] = temp;

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
