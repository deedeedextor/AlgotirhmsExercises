using System;

namespace ReturnRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReturnRemainder(3, 0));
        }

        private static int ReturnRemainder(int x, int y)
        {
            if (y == 0)
            {
                throw new Exception("Can not divide by zero");
            }

            if (x < y)
            {
                throw new Exception("The number being divided can not be less than the divisor");
            }

            return x % y;
        }
    }
}
