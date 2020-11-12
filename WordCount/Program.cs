using System;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountWordsInAString("Welcome to my world"));
        }

        private static int CountWordsInAString(string str)
        {
            int count = 0;

            str = str.Replace("  ", " ").Trim();

            if (str != "")
            {
                foreach (var word in str.Split(" "))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
