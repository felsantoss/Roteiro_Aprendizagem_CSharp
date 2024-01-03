using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipo integral com sinal:");

            Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

            Console.WriteLine("");
            Console.WriteLine("Tipo integral sem sinal");

            Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

            Console.WriteLine("");
            Console.WriteLine("Tipo ponto flutuante");

            Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue}");
            Console.WriteLine($"double : {double.MinValue} to {double.MaxValue}");
            Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue}");

            Console.ReadKey();
        }
    }
}
