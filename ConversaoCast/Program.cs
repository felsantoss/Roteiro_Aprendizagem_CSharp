﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoCast
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* int first = 2;
            string second = "4";
            string result = first + second;
            Console.WriteLine(result); */

            int myInt = 3;
            Console.WriteLine($"int: {myInt}");

            decimal myDecimal = myInt;
            Console.WriteLine($"decimal: {myDecimal}");

            Console.ReadKey();
        }
    }
}