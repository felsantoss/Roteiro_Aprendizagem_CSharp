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

            string[] fraudulentOrderIDs = new string[3]; // declaração da matriz

            // adicionando valores aos elementos da matriz
            fraudulentOrderIDs[0] = "A123";
            fraudulentOrderIDs[1] = "B456";
            fraudulentOrderIDs[2] = "C789";

            Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

            fraudulentOrderIDs[0] = "F000";

            Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

            Console.ReadKey();
        }

        
    }
}
