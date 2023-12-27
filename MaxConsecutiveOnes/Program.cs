using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxConsecutiveOnes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Given a binary array nums, return the maximum number of consecutive 1's in the array.
            int[] numsArr = { 1, 0, 1, 1, 0, 1 };

            int findMaxConsecutiveOnes(int[] nums)
            {
                int numsOfConsecutiveOnes = 0;
                int numOfMaxCount = 0;

                // keep track of how many 1's you've seen in a row.
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == 1)
                    {
                        numsOfConsecutiveOnes++;
                    }
                    else
                    {
                        numsOfConsecutiveOnes = 0;
                    }

                    numOfMaxCount = Math.Max(numOfMaxCount, numsOfConsecutiveOnes);
                }

                return numOfMaxCount;
            }

            Console.WriteLine(findMaxConsecutiveOnes(numsArr));

        }
    }
}
