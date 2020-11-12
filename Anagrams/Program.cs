using System;

namespace Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            FindFindIfTwoStringsAreAnagrams("silent", "Listen");
            FindFindIfTwoStringsAreAnagrams(" ", "   ");
        }

        private static void FindFindIfTwoStringsAreAnagrams(string wordOne, string wordTwo)
        {
            if (wordOne.Length > 0 && wordTwo.Length > 0 && !string.IsNullOrWhiteSpace(wordOne) && !string.IsNullOrWhiteSpace(wordTwo))
            {
                char[] wordOneChar = wordOne.ToLower().ToCharArray();
                char[] wordTwoChar = wordTwo.ToLower().ToCharArray();

                Array.Sort(wordOneChar);
                Array.Sort(wordTwoChar);

                string newWordOne = new string(wordOneChar);
                string newWordTwo = new string(wordTwoChar);

                if (newWordOne == newWordTwo)
                {
                    Console.WriteLine("Yes! Words \"{0}\" and \"{1}\" are Anagrams", wordOne, wordTwo);
                }
                else
                {
                    Console.WriteLine("No! Words \"{0}\" and \"{1}\" are not Anagrams", wordOne, wordTwo);
                }
            }
            else
            {
                Console.WriteLine("Please, enter two words!");
            }
        }
    }
}
