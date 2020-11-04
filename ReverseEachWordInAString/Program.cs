using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseEachWordInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseEachWordInAStringUsingStack("Hello and welcome");
            ReverseEachWordInAStringUsingLinq("Hello and welcome");
        }

        private static void ReverseEachWordInAStringUsingLinq(string str)
        {
            string reversedWordString = string.Join(" ", str.Split(' ').Select(x => new string(x.Reverse().ToArray())));

            Console.WriteLine(reversedWordString);
        }

        private static void ReverseEachWordInAStringUsingStack(string str)
        {
            Stack<char> charStack = new Stack<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    charStack.Push(str[i]);
                }
                else
                {
                    while (charStack.Count > 0)
                    {
                        Console.Write(charStack.Pop());
                    }
                    Console.Write(" ");
                }
            }

            while (charStack.Count > 0)
            {
                Console.Write(charStack.Pop());
            }
            Console.WriteLine();
        }
    }
}
