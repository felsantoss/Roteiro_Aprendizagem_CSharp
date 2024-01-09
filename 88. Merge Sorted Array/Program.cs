using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _88.Merge_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Merge(int[] nums1, int m, int[] nums2, int n)
            {
                int i = m - 1, j = n - 1, k = m + n - 1;

                while (i >= 0 && j >= 0)
                {
                    if (nums1[i] < nums2[j])
                    {
                        nums1[k--] = nums2[j--];
                    }
                    else
                    {
                        nums1[k--] = nums1[i--];
                    }
                }
                while (j >= 0)
                {
                    nums1[k--] = nums1[j--];
                }
            }

            int[] firstArr = { 1, 2, 3, 0, 0, 0 };
            int[] secondArr = { 2, 5, 6 };

            Merge(firstArr, secondArr);

            Console.ReadKey();
        }
    }
}
