using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
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

            string value = "abc123";
            char[] valueArray = value.ToCharArray();
            Array.Reverse(valueArray);

            // string result = new string(valueArray);
            string result = String.Join(",", valueArray); // Join() concatena os itens com um separador especificado
            Console.WriteLine(result);

            string[] items = result.Split(',');
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }

            // Desafio

            string pangram = "The quick brown fox jumps over the lazy dog";

            // Step 1
            string[] message = pangram.Split(' ');

            //Step 2
            string[] newMessage = new string[message.Length];

            // Step 3
            for (int i = 0; i < message.Length; i++)
            {
                char[] letters = message[i].ToCharArray();
                Array.Reverse(letters);
                newMessage[i] = new string(letters);
            }

            //Step 4
            string finalResult = String.Join(" ", newMessage);
            Console.WriteLine(finalResult);

            Console.Clear();

            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            string[] ordersSeparate = orderStream.Split(',');
            Array.Sort(ordersSeparate);

            foreach (var order in ordersSeparate)
            {
                if (order.Length == 4)
                    Console.WriteLine(order);

                else
                    Console.WriteLine($"{order} - Error");
            }
        
            Console.ReadKey();
        }
    }
}
