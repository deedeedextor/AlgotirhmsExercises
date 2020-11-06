using System;
using System.Linq;
using System.Text;

namespace FindAllSubstrings
{
    class Program
    {
        static void Main(string[] args)
        {
            FindAllSubstrings("abc");
            FindAllSubstringsUsingSubstringMethod("abab");
            FindUniqueSubstring("asd");
            FindUniqueSubstringUsingLinq("asd");
        }

        private static void FindUniqueSubstringUsingLinq(string str)
        {
            var Substrings =
                   from i in Enumerable.Range(0, str.Length)
                   from j in Enumerable.Range(0, str.Length - i + 1)
                   where j >= 1
                   select str.Substring(i, j);

            foreach (string substring in Substrings)
            {
                Console.Write(substring + " ");
            }
            Console.WriteLine();

            foreach (string substring in Substrings.Distinct())
            {
                Console.Write(substring + " ");
            }
            Console.WriteLine();
        }

        private static void FindUniqueSubstring(string str)
        {
            int temp = 0;
            //Total possible substrings for string of size n  
            String[] SubstringArray = new String[str.Length * (str.Length + 1) / 2];
 
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str.Length - i; j++)
                {
                    SubstringArray[temp] = str.Substring(i, j + 1);
                    temp++;
                }
            }

            SubstringArray = SubstringArray.Distinct().ToArray();

            for (int i = 0; i < SubstringArray.Length; i++)
            {
                Console.Write(SubstringArray[i] + " ");
            }
            Console.WriteLine();
        }

        private static void FindAllSubstringsUsingSubstringMethod(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < str.Length - i; j++)
                {
                    Console.Write(str.Substring(i, j + 1) + " ");
                }
            }

            Console.WriteLine();
        }

        private static void FindAllSubstrings(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                StringBuilder subString = new StringBuilder(str.Length - i);

                for (int j = i; j < str.Length; j++)
                {
                    subString.Append(str[j]);
                    Console.Write(subString + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
