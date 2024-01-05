using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateZeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void DuplicateZeros(int[] arr)
            {
                for (int i = 0;  i < arr.Length - 1; i++)
                {
                    if (arr[i] == 0)
                    {
                        for (int j = arr.Length - 1; j > i; j--)
                        {
                            arr[j] = arr[j - 1];
                        }
                        i++;
                    }
                    
                }
            }

            int[] array = { 1, 0, 2, 3, 0, 4, 5, 0 };

            DuplicateZeros(array);

            foreach (int var in array)
            {
                Console.WriteLine(var);
            }

            Console.ReadKey();
        }
    }
}
