using System;

namespace FibonacciSeries
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FibonacciSeriesIterativeApproach(0, 1, 0, 10);
            FibonacciSeriesRecursiveApproach(0, 1, 1, 10);
            Console.WriteLine();

            Console.WriteLine(FindTheNthFibonacciSeriesWithRecursion(10 - 1));
            Console.WriteLine(FindTheNthFibonacciSeriesWithoutRecursion(10));
        }

        private static int FindTheNthFibonacciSeriesWithoutRecursion(int number)
        {
            int firstNumber = 0, secondNumber = 1, nextNumber = 0;

            if (number == 0)
            {
                return firstNumber;
            }

            for (int i = 2; i < number; i++)
            {
                nextNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }

            return secondNumber;
        }

        private static int FindTheNthFibonacciSeriesWithRecursion(int number)
        {
            if ((number == 0) || (number == 1))
            {
                return number;
            }
            else
            {
                return (FindTheNthFibonacciSeriesWithRecursion(number - 1) + FindTheNthFibonacciSeriesWithRecursion(number - 2));
            }
        }

        private static void FibonacciSeriesRecursiveApproach(int firstNumber, int secondNumber, int counter, int numberOfElements)
        {
            Console.Write(firstNumber + " ");
            if (counter < numberOfElements)
            {
                FibonacciSeriesRecursiveApproach(secondNumber, firstNumber + secondNumber, counter + 1, numberOfElements);
            }
        }

        private static void FibonacciSeriesIterativeApproach(int firstNumber, int secondNumber, int nextNumber, int numberOfElements)
        {
            if (numberOfElements < 2)
            {
                Console.WriteLine("Please, enter a number greater than two!");
            }
            else
            {
                Console.Write(firstNumber + " " + secondNumber + " ");

                for (int i = 2; i < numberOfElements; i++)
                {
                    nextNumber = firstNumber + secondNumber;
                    Console.Write(nextNumber + " ");
                    firstNumber = secondNumber;
                    secondNumber = nextNumber;
                }
            }
            Console.WriteLine();
        }
    }
}
