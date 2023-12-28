using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Find_Numbers_with_Even_Number_of_Digits
{
    internal class Program
    {
        // Given an array nums of integers, return how many of them contain an even number of digits.
        static void Main(string[] args)
        {
            // Example of how to find numbers of digits 

            int number = 2;

            int numberOfDigits = 0;

            while (number != 0)
            {
                number /= 10;
                numberOfDigits++;
            }

            if (numberOfDigits % 2 == 0)
                Console.WriteLine($"Even number, total of digits: {numberOfDigits}");
            else
                Console.WriteLine($"Odd number, total of digits: {numberOfDigits}");

            int findNumbers(int[] nums)
            {
                int count = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    int arrayNumber = nums[i];

                    string numString = arrayNumber.ToString();

                    if (numString.Length % 2 == 0)
                    {
                        count++;
                    }
                }
                return count;
            }

            int[] arr = { 12, 345, 2, 6, 7896 };

            Console.WriteLine(findNumbers(arr));

            Console.ReadKey();
        }
    }
}
