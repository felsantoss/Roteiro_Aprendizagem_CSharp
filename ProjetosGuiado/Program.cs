using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosGuiado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNormal = {3, 2, 1};

            Array.Sort(arrayNormal);

            Console.WriteLine(arrayNormal); 

            Console.ReadKey();
        }
    }
}
