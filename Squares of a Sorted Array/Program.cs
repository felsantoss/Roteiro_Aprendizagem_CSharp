using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squares_of_a_Sorted_Array
{
    internal class Program
    {
        // Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] SortedSquares(int[] nums)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = nums[i] * nums[i];
                }

                Array.Sort(nums);

                return nums;
            }

            int[] arr = { -7, -3, 2, 3, 11 };
            int[] squareArray = SortedSquares(arr);

            Console.WriteLine(string.Join(", ", squareArray));

            Console.ReadKey();
        }
    }
}
