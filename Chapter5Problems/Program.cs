using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter5Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 5; ++i)
            {
                int[] intArray1 = new int[5];
                int[] nums1 = { 0, 1, 2, 3, 4, 5 };
                Console.WriteLine(nums1[i]);
            }

            Console.WriteLine(" ");

            for (int x = 5; x >= 0; --x)
            {
                int[] intArray1 = new int[5];
                int[] nums1 = { 0, 1, 2, 3, 4, 5 };
                Console.WriteLine(nums1[x]);

            }
        }
    }
}
