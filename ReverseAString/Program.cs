using System;
using System.Linq;

namespace ReverseAString
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseAStringUsingBuildingMethod("Welcome to my world");
            ReverseAStringUsingForLoop("Welcome to my world");

        }

        private static void ReverseAStringUsingForLoop(string str)
        {
            string reversedString = string.Empty;

            for (int i = str.Length - 1; i >=0 ; i--)
            {
                reversedString += str[i];
            }

            Console.WriteLine(reversedString);
        }

        private static void ReverseAStringUsingBuildingMethod(string str)
        {
            char[] charString = str.ToCharArray();

            Array.Reverse(charString);

            Console.WriteLine(new string(charString));
        }
    }
}
