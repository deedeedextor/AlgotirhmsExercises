using System;
using System.Collections.Generic;

namespace NumberInCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            TurnNumberInCharacters(375123);
        }

        private static void TurnNumberInCharacters(int number)
        {
            int remainder = 0;
            Stack<int> digits = new Stack<int>();

            while (number > 0)
            {
                remainder = number % 10;
                digits.Push(remainder);
                number /= 10;
            }

            foreach (var digit in digits)
            {
                FindStringRepresentationOfNumber(digit);
            }
        }

        private static void FindStringRepresentationOfNumber(int digit)
        {
            switch (digit)
            {
                case 1:
                    Console.Write("one ");
                    break;
                case 2:
                    Console.Write("two ");
                    break;
                case 3:
                    Console.Write("three ");
                    break;
                case 4:
                    Console.Write("four ");
                    break;
                case 5:
                    Console.Write("five ");
                    break;
                case 6:
                    Console.Write("six ");
                    break;
                case 7:
                    Console.Write("seven ");
                    break;
                case 8:
                    Console.Write("eight ");
                    break;
                case 9:
                    Console.Write("nine ");
                    break;
                default:
                    break;
            }
        }
    }
}
