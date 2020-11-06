using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveDuplicateCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoveDuplidateCharacters("abcabc");
            RemoveDuplicateCharactersUsingHashSet("123123");
            RemoveDuplicateCharactersUsingLinq("er12et13");
        }

        private static void RemoveDuplicateCharactersUsingLinq(string str)
        {
            var charArray = str.ToCharArray().Distinct().ToArray();
            var result = new string(charArray);

            Console.WriteLine(result);
        }

        private static void RemoveDuplicateCharactersUsingHashSet(string str)
        {
            string result = string.Empty;
            var unique = new HashSet<char>(str);

            foreach (var ch in unique)
            {
                result += ch;
            }

            Console.WriteLine(result);
        }

        private static void RemoveDuplidateCharacters(string str)
        {
            string result = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (!result.Contains(str[i]))
                {
                    result += str[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}
