using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace MajorityElementInAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            FindMajorityElement(new int[] { 1, 2, 3, 4, 5, 2, 2, 2, 2 });
        }

        private static void FindMajorityElement(int[] array)
        {
            Dictionary<int, int> dict = array
                .GroupBy(ch => ch)
                .ToDictionary(ch => ch.Key, ch => ch.Count());

            var item = dict.OrderByDescending(x => x.Value)
                .Select(x => x.Key)
                .First();

            Console.WriteLine(item);
        }
    }
}
