using System;

namespace SwappingTwoNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SwappingTwoNumbersWithTemp(10, 20, 0);
            Console.WriteLine();

            SwappingTwoNumbersWithAddition(10, 20);
            Console.WriteLine();

            SwappingTwoNumbersWithMultiplication(10, 20);
            Console.WriteLine();
        }

        private static void SwappingTwoNumbersWithMultiplication(int x, int y)
        {
            Console.WriteLine($"Before swapping: {x}, {y}");

            x = x * y;
            y = x / y;
            x = x / y;

            Console.WriteLine($"After swapping: {x}, {y}");
        }

        private static void SwappingTwoNumbersWithAddition(int x, int y)
        {
            Console.WriteLine($"Before swapping: {x}, {y}");

            x = x + y;
            y = x - y;
            x = x - y;

            Console.WriteLine($"After swapping: {x}, {y}");
        }

        private static void SwappingTwoNumbersWithTemp(int x, int y, int z)
        {
            Console.WriteLine($"Before swapping: {x}, {y}");

            z = x;
            x = y;
            y = z;

            Console.WriteLine($"After swapping: {x}, {y}");
        }
    }
}
