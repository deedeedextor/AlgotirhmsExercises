using System;
using static BruteForceAlgorithm.BruteForceAlgo;

namespace BruteForceAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            BruteForceTest testCallBack = delegate (ref char[] testChars)
            {
                var str = new string(testChars);
                return str == "bbc";
            };

            bool result = BruteForce("abcde", 1, 5, testCallBack);
            Console.WriteLine(result);
        }
    }
}
