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

            Console.WriteLine("escape\nespecial"); // \n adicionára uma nova linha 
            Console.WriteLine("escape\tespecial");

            Console.ReadKey();
        }

        
    }
}
