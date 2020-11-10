using System;

namespace ConvertTwoDimensionalArrayToOne
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertTwoDimensionalArrayToOne(new int[2, 3]{ { 1, 2, 3 }, { 4, 5, 6 } });
        }

        private static void ConvertTwoDimensionalArrayToOne(int[,] array)
        {
            int index = 0;

            int NoOfRows = array.GetLength(0);
            int NoOfColumns = array.GetLength(1);

            int[] OneDimensionalArray = new int[NoOfRows * NoOfColumns];

            // Row wise convertion
            for (int i = 0; i < NoOfRows; i++)
            {
                for (int j = 0; j < NoOfColumns; j++)
                {
                    OneDimensionalArray[index] = array[i, j];
                    index++;
                }
            }

            foreach (int item in OneDimensionalArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
