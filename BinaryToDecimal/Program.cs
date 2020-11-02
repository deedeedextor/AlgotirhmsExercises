using System;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertBinaryToDecimal(10101);
            ConvertToInt32BinaryToDecimal(100);
        }

        private static void ConvertToInt32BinaryToDecimal(int number)
        {
            int decimalValue = Convert.ToInt32(number.ToString(), 2);

            Console.Write($"Decimal Value : {decimalValue}");
            Console.WriteLine();
        }

        private static void ConvertBinaryToDecimal(int number)
        {
            int decimalValue = 0;
            
            //initializing base value to 1 => 2^0
            int baseOne = 1;

            while (number > 0)
            {
                int reminder = number % 10;
                number /= 10;
                decimalValue += reminder * baseOne;
                baseOne *= 2;
            }

            Console.Write($"Decimal Value : {decimalValue}");
            Console.WriteLine();
        }
    }
}
