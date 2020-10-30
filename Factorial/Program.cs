using System;

namespace Factorial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FindFactorial(6);
            FindFactorialUsingWhileLoop(10);
            Console.WriteLine($"Factorial is: {FindFactorialRecursively(8)}");
        }

        private static long FindFactorialRecursively(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * FindFactorialRecursively(number - 1);
            }
        }

        private static void FindFactorialUsingWhileLoop(int number)
        {
            int currentNumber = number;
            long factorial = 1;

            while (number != 1)
            {
                factorial = factorial * number;
                number--;
            }

            Console.WriteLine($"Factorial of {currentNumber} is: {factorial}");
        }

        private static void FindFactorial(int number)
        {
            long factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine($"Factorial of {number} is: {factorial}");
        }
    }
}
