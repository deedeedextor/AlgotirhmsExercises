using System;

namespace GreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetGCD(10, 135));
            Console.WriteLine(GetGCDUsingRecursion(10, 135));
        }

        private static int GetGCDUsingRecursion(int x, int y)
        {
            if (x == 0)
            {
                return y;
            }
            if (y == 0)
            {
                return x;
            }

            if (x > y )
            {
                return GetGCDUsingRecursion(x % y, y);
            }
            else
            {
                return GetGCDUsingRecursion(x, y % x);
            }
        }

        private static int GetGCD(int x, int y)
        {
            while (x != y)
            {
                if (x > y)
                {
                    x -= y;
                }
                if (x < y)
                {
                    y -= x;
                }
            }

            return x;
        }
    }
}
