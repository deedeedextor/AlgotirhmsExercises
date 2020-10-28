using System;

namespace SwappingTwoStrings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SwappingTwoStringsWithoutThirdOne("str", "rts");
            Console.WriteLine();
        }

        private static void SwappingTwoStringsWithoutThirdOne(string x, string y)
        {
            Console.WriteLine($"Before swapping: {x}, {y}");

            x = x + y;
            y = x.Substring(0, x.Length - y.Length);
            x = x.Substring(y.Length);

            Console.WriteLine($"After swapping: {x}, {y}");
        }
    }
}
