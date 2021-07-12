using System;
using System.Collections.Generic;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            //With my method
            Console.WriteLine(BinarySearch(test, 305));
            //With built in C# method
            test.Sort();
            Console.WriteLine(Array.BinarySearch(test.ToArray(), 305));
        }
        private static int BinarySearch(List<int> list,int item)
        {
            list.Sort();
            int start = 0;
            int end = list.Count()-1;
            while (start <= end)
            {
                var mid=(start+end)/2;
                if (list[mid]==item)
                {
                    return mid;
                }
                else if (item<list[mid])
                {
                    end = mid - 1;

                }
                else
                {
                    start = mid + 1;
                }
            }

            return -1;
        }
    }
}
