using System;
using System.Linq;

namespace DecimalToBinary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConvertDecimalToBinary(5);
            ConvertDecimalToBinaryUsingString(8);
            ConvertDecimalToBinaryUsingString(10);
        }

        private static void ConvertDecimalToBinaryUsingString(int number)
        {
            string binary = string.Empty;

            for (int i = 0; number > 0; i++)
            {
                binary += number % 2;
                number /= 2;
            }

            Console.WriteLine(new string(binary.Reverse().ToArray()));
        }

        private static void ConvertDecimalToBinary(int number)
        {
            int i;
            int[] numberArray = new int[10];

            for (i = 0; number > 0; i++)
            {
                numberArray[i] = number % 2;
                number /= 2;
            }

            for (i -= 1; i >= 0; i--)
            {
                Console.Write(numberArray[i]);
            }

            Console.WriteLine();
        }
    }
}
