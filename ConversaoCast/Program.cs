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

             int first = 2;
            string second = "4";
            string result = first + second;
            Console.WriteLine(result); 

            int myInt = 3;
            Console.WriteLine($"int: {myInt}");

            decimal myDecimal = myInt;
            Console.WriteLine($"decimal: {myDecimal}"); 


            Console.WriteLine("\nConversão por Coerção");
            decimal myDecimals = 3.14m;
            Console.WriteLine($"decimal: {myDecimals}");

            int myInts = (int)myDecimals; // conversão feita por Coerção, colocando () ao lado da variavel
            Console.WriteLine($"int: {myInts}"); 


            Console.WriteLine("\nconversão de Restrição"); // você pode perder informações como precisão (ou seja, o número de valores após o ponto decimal).
            decimal myDecimalss = 1.23456789m;
            float myFloat = (float)myDecimalss;

            Console.WriteLine($"Decimal: {myDecimalss}");
            Console.WriteLine($"Float  : {myFloat}"); 

            Console.WriteLine("\nConvertendo número para String usando ToString()");
            int firstA = 5;
            int secondA = 7;
            string message = firstA.ToString() + secondA.ToString();

            Console.WriteLine(message); 

            Console.WriteLine("\nConvertendo String em Int usando Parse()");
            string firstT = "5";
            string secondD = "7";
            int sum = int.Parse(firstT) + int.Parse(secondD);
            Console.WriteLine(sum); 

            /* Você usou o método Convert.ToInt32() com uma cadeia de caracteres aqui, 
             * mas provavelmente deve usar TryParse() quando possível.
             * Então, quando usar a classe Convert? A classe Convert é melhor para converter números fracionários em números inteiros (int) 
             * porque os arredonda da maneira esperada.
             */

             Console.WriteLine("\nConversão utilizando a classe Convert");
            string value1 = "5";
            string value2 = "7";
            int resultsS = Convert.ToInt32(value1) * Convert.ToInt32(value2);
            Console.WriteLine(resultsS); 

            int value = (int)1.5m; // casting truncates
            Console.WriteLine(value);

            int value11 = Convert.ToInt32(1.5m); // casting rounds up
            Console.WriteLine(value11); 

            string valuess = "bad";
            int resultss = 0;

            if (int.TryParse(valuess, out resultss))
            {
                Console.WriteLine($"Resultado: {resultss}");
            }
            else
            {
                Console.WriteLine("Não foi possível exibir o resultado.");
            }

            if (resultss > 0)
                Console.WriteLine($"Resultado (c/ desvio): {50 + resultss}"); 

            string[] valuesT = { "12.3", "45", "ABC", "11", "DEF" };

            decimal total = 0m;
            string messagee = "";

            foreach (var valueE in valuesT)
            {
                decimal number; // stores the TryParse "out" value
                if (decimal.TryParse(valueE, out number))
                {
                    total += number;
                }
                else
                {
                    message += value;
                }
            }

            Console.WriteLine($"Message: {message}");
            Console.WriteLine($"Total: {total}"); 

            int value111 = 12;
            decimal value22 = 6.2m;
            float value33 = 4.3f;


            int result1 = Convert.ToInt32(value111 / value22);
            // Hint: You need to round the result to nearest integer (don't just truncate)
            Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

            decimal result2 = value22 / (decimal)value33;
            Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

            float result3 = value33 / (float)value111;
            Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

            Console.ReadKey();  
        }
    }
}
