using System;
using System.Linq;

namespace PalindromeNumbersAndStrings
{
   public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(IsAPalindromeNumber(121));
            Console.WriteLine(IsAPalindromeString("abcba"));
        }

        private static bool IsAPalindromeString(string x)
        {
            bool isPalindrome = false;

            // options with foreach or for loop
            char[] xArray = x.ToCharArray();
            Array.Reverse(xArray);
            string reverse = new string(xArray);

            if (x == reverse)
            {
                isPalindrome = true;
            }

            return isPalindrome;
        }

        private static bool IsAPalindromeNumber(int x)
        {
            int reminder = 0, sum = 0;
            bool isPalindrome = false;
            int temp = x;

            // with the same approach we cam reverse a number
            do
            {
                reminder = x % 10;

                sum = (sum * 10) + reminder;

                x = x / 10;

            } while (x > 0);

            if (temp == sum)
            {
                isPalindrome = true;
            }

            return isPalindrome;
        }
    }
}
