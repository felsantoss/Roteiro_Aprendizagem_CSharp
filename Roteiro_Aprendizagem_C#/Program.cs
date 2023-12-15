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

            Console.WriteLine("Hello \"World\"!"); // utilizando o \ entre uma palavra conseguimos usar as duplas dentro de uma string

            Console.ReadKey();
        }

        
    }
}
