using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesComMatrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pallets = { "B14", "A11", "B12", "A13" };

            Console.WriteLine("Sorted...");
            Array.Sort(pallets); // Classifica os itens em ordem crescente 

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine("\nReversed...");
            Array.Reverse(pallets); // Interve a ordem dos itens 

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine($"Before: {pallets[0]}");
            Array.Clear(pallets, 0, 2); // Método para limpar valores (array, i inicial, n i para limpar)
            Console.WriteLine($"After: {pallets[0]}");

            Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Array.Resize(ref pallets, 3); // altera o tamanho de uma matriz para o tamanho especificado
            Console.WriteLine($"\nResizing 6 ... count: {pallets.Length}");

            // pallets[4] = "C01";
            // pallets[5] = "C02";

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.ReadKey();
        }
    }
}
