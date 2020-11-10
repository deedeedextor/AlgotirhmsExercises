using System;

namespace ConvertOneDimensionalArrayToTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertOneDimensionalArrayToTwo(2, 3, new int[2 * 3] { 1, 2, 3, 4, 5, 6 });
        }

        private static void ConvertOneDimensionalArrayToTwo(int rows, int columns, int[] array)
        {
            int index = 0;
            int[,] twoDimensionalArray = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    twoDimensionalArray[i, j] = array[index];
                    index++;
                }
            }

            for (int x = 0; x < twoDimensionalArray.GetLength(0); x++)
            {
                for (int y = 0; y < twoDimensionalArray.GetLength(1); y++)
                {
                    Console.Write(twoDimensionalArray[x, y]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
