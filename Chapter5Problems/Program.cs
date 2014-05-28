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
            int[] intArray = new int[5];
            int[] nums = { 1, 2, 3, 4, 5 };

            for (int i = 5; i >= 0; --i)
            {
                Console.Write(nums[i]);
            }

        }
    }
}
