using System;

namespace ArmstrongNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(IsArmstrongNumber(8208));
            FindArmstrongNumbersBetweenGivenRange(153, 500);
        }

        private static void FindArmstrongNumbersBetweenGivenRange(int x, int y)
        {
            for (int i = x; i < y; i++)
            {
                int sum = 0;
                int temporaryNumber = i;
                int temp = 0;
                int length = i.ToString().Length;

                while (temporaryNumber != 0)
                {
                    temp = temporaryNumber % 10;
                    temporaryNumber = temporaryNumber / 10;
                    sum += (int)Math.Pow(temp, length);
                }

                if (sum == i)
                {
                    Console.Write($"{i} ");
                }
            }
        }

        private static bool IsArmstrongNumber(int x)
        {
            bool isArmstrong = false;
            int i = 0;
            int digitCount = 0;
            int[] digitArray = new int[10];
            double sum = 0;

            int temporaryNumber = x;

            while (x > 0)
            {
                digitArray[i++] = x % 10;
                x = x / 10;
                digitCount++;
            }

            for (i = 0; i < digitCount; i++)
            {
                sum += Math.Pow(digitArray[i], digitCount);
            }

            if (sum == temporaryNumber)
            {
                isArmstrong = true;
            }

            return isArmstrong;
        }
    }
}
