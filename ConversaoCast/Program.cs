using System;
using System.Collections.Generic;
using System.Globalization;
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
            Console.WriteLine(result); 

            int myInt = 3;
            Console.WriteLine($"int: {myInt}");

            decimal myDecimal = myInt;
            Console.WriteLine($"decimal: {myDecimal}"); 


            Console.WriteLine("\nConversão por Coerção");
            decimal myDecimal = 3.14m;
            Console.WriteLine($"decimal: {myDecimal}");

            int myInt = (int)myDecimal; // conversão feita por Coerção, colocando () ao lado da variavel
            Console.WriteLine($"int: {myInt}"); 


            Console.WriteLine("\nconversão de Restrição"); // você pode perder informações como precisão (ou seja, o número de valores após o ponto decimal).
            decimal myDecimal = 1.23456789m;
            float myFloat = (float)myDecimal;

            Console.WriteLine($"Decimal: {myDecimal}");
            Console.WriteLine($"Float  : {myFloat}"); 

            Console.WriteLine("\nConvertendo número para String usando ToString()");
            int first = 5;
            int second = 7;
            string message = first.ToString() + second.ToString();

            Console.WriteLine(message); 

            Console.WriteLine("\nConvertendo String em Int usando Parse()");
            string first = "5";
            string second = "7";
            int sum = int.Parse(first) + int.Parse(second);
            Console.WriteLine(sum); */

            /* Você usou o método Convert.ToInt32() com uma cadeia de caracteres aqui, 
             * mas provavelmente deve usar TryParse() quando possível.
             * Então, quando usar a classe Convert? A classe Convert é melhor para converter números fracionários em números inteiros (int) 
             * porque os arredonda da maneira esperada.
             */

            /* Console.WriteLine("\nConversão utilizando a classe Convert");
            string value1 = "5";
            string value2 = "7";
            int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
            Console.WriteLine(result); */

            int value = (int)1.5m; // casting truncates
            Console.WriteLine(value);

            int value1 = Convert.ToInt32(1.5m); // casting rounds up
            Console.WriteLine(value1);


            Console.ReadKey();
        }
    }
}
