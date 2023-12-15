using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro_Aprendizagem_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Adicionando Sequências de escape de caractere 
            // Uma sequência de caracteres de escape é uma instrução especial para que o runtime insira um caractere especial que afetará a saída da cadeia de caracteres.

            Console.WriteLine("escape\nespecial"); // \n adicionará uma nova linha "quebra de linha"
            Console.WriteLine("escape\tespecial"); // \t adicionará um espaço a mais entre as palavras

            Console.WriteLine("Hello \"World\"!\n"); // utilizando o \ entre uma palavra conseguimos usar as duplas dentro de uma string

            ///////////////////////////////////////////

            // Introdução a Matrizes 
            // As matrizes podem ser usadas para armazenar vários valores do mesmo tipo em uma só variável.

            // Exercicio - Matrizes - Seu trabalho no departamento de segurança se concentra em encontrar um padrão para os pedidos fraudulentos.

            /* string[] fraudulentOrderIDs = new string[3]; // declaração da matriz

            // adicionando valores aos elementos da matriz
            fraudulentOrderIDs[0] = "A123";
            fraudulentOrderIDs[1] = "B456";
            fraudulentOrderIDs[2] = "C789"; */

            string[] fraudulentOrderIDs = { "A123", "B456", "C789" }; // declaração de matriz com valores já definidos

            Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

            fraudulentOrderIDs[0] = "F000";

            Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

            Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.\n");

            // Implementar a instrução foreach
            // foreach fornece uma maneira simples e limpa de iterar através dos elementos de uma matriz.

            // Exercicio - foreach - Use a instrução foreach para criar uma soma de todos os itens disponíveis em cada compartimento do depósito.

            int[] inventory = { 200, 450, 700, 175, 250 };

            int sum = 0; // variavel para armazenar o valor da soma do array

            foreach (int items in inventory)
            {
                sum += items; // adicionando o valor da soma total do array na variavel sum
            }

            Console.WriteLine($"We have {sum} items in inventory\n");

            string[] fraudulentOrders = { "B123", "C234", "A345", "C15", "B117", "G3003", "C235", "B179" };

            foreach (string order in fraudulentOrders)
            {
                if (order.StartsWith("B"))
                {
                    Console.WriteLine(order);
                }
            }

            Console.ReadKey();
        }

        
    }
}
