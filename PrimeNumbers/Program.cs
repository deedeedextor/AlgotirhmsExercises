using System;
using System.Diagnostics.Tracing;

namespace PrimeNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(IsPrimeNumber(103));
            PrimeNumbersBetweenAGivenRange(1, 20);

        }

        private static void PrimeNumbersBetweenAGivenRange(int x, int y)
        {
            for (int i = x; i <= y; i++)
            {
                int counter = 0;

                for (int j = 2; j <= i/2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0 && i != 1)
                {
                    Console.Write($"{i } ");
                }
            }
        }

        private static bool IsPrimeNumber(int x)
        {
            bool isPrime = true;

            for (int i = 2; i < x/2; i++)
            {
                if (x % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }
    }
}
