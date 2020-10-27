using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 234, 56, 12, 34, 456, 213, 82, 1, 18 };
            var sortedArr = QuickSort(arr);

            Console.WriteLine(string.Join(", ", sortedArr));
        }

        private static int[] QuickSort(int[] arr)
        {

            if (arr.Length == 0)
            {
                return new int[0];
            }

            var pivot = arr[0];
            var left = new List<int>();
            var right = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < pivot)
                {
                    left.Add(arr[i]);
                }

                if (arr[i] > pivot)
                {
                    right.Add(arr[i]);
                }
            }

            return QuickSort(left.ToArray())
                .Concat(new int[] { pivot })
                .Concat(QuickSort(right.ToArray()))
                .ToArray();
        }
    }
}
