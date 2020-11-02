using System;
using System.Linq;

namespace SumOfDigits
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FindSumOfDigits(36782);
            FindSumOfDigitsUsingLinq(45321);
            Console.WriteLine($"The sum is: {FindSumOfDigitsRecursively(15)}");
        }

        private static int FindSumOfDigitsRecursively(int number)
        {
            if (number != 0)
            {
                return (number % 10 + FindSumOfDigitsRecursively(number / 10));
            }
            else
            {
                return 0;
            }
        }

        private static void FindSumOfDigitsUsingLinq(int number)
        {
            int sum = number.ToString().Select(digit =>
            int.Parse(digit.ToString())).ToArray().Sum();

            Console.WriteLine($"The sum is: {sum}");
        }

        private static void FindSumOfDigits(int number)
        {
            int sum = 0, reminder;

            while (number > 0)
            {
                reminder = number % 10;
                sum += reminder;
                number /= 10;
            }

            Console.WriteLine($"The sum is: {sum}");
        }
    }
}
