using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;

namespace CharacterOccurrencesInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            CountCharacterOccurrencesInAString("Hello world");
            CountCharacterOccurrencesInAStringUsingDictionary("Hello to the world");
            CountCharacterOccurrencesInAStringUsingLinq("Welcome to my world");
        }

        private static void CountCharacterOccurrencesInAStringUsingLinq(string str)
        {
            Dictionary<char, int> characters = str
                .Replace(" ", string.Empty)
                .GroupBy(ch => ch)
                .ToDictionary(ch => ch.Key, ch => ch.Count());

            foreach (var item in characters.Keys)
            {
                Console.WriteLine(item + ":" + characters[item]);
            }
        }

        private static void CountCharacterOccurrencesInAStringUsingDictionary(string str)
        {
            var characters = new Dictionary<char, int>();

            foreach (var currChar in str.Replace(" ", string.Empty))
            {
                if (!characters.ContainsKey(currChar))
                {
                    characters.Add(currChar, 0);
                }
                characters[currChar]++;
            }

            foreach (var item in characters.Keys)
            {
                Console.WriteLine(item + ":" + characters[item]);
            }
        }

        private static void CountCharacterOccurrencesInAString(string str)
        {
            str = str.Replace(" ", string.Empty);

            while (str.Length > 0)
            {
                Console.Write(str[0] + ":");
                int count = 0;

                for (int i = 0; i < str.Length; i++)
                {
                    if (str[0] == str[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                str = str.Replace(str[0].ToString(), string.Empty);
            }
        }
    }
}
