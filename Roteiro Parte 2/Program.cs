using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Authentication;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Roteiro_Parte_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string value1 = " a";
            //string value2 = "A ";

            //Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

            //Console.WriteLine("a" != "a");
            //Console.WriteLine("a" != "A");
            //Console.WriteLine(1 != 2);

            //string myValue = "a";

            //Console.WriteLine(myValue != "a");

            //Console.WriteLine(1 > 2);
            //Console.WriteLine(1 < 2);
            //Console.WriteLine(1 >= 1);
            //Console.WriteLine(1 <= 1);  

            string pangram = "The quick brown fox jumps over the lazy dog.";

            Console.WriteLine(pangram.Contains("fox"));
            Console.WriteLine(!pangram.Contains("cow"));

            // operador condicional ?: 
            // <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

            int saleAmount = 1001;
            // int discount = saleAmount > 1000 ? 100 : 50;
            
            Console.WriteLine($"\nDiscount: {(saleAmount > 1000 ? 100 : 50)}");

            Console.WriteLine("\nChallenger of heads and tails\n");

            Random coin = new Random();

            int flip = coin.Next(0, 2);

            Console.WriteLine((flip == 0) ? "heads" : "tails\n");


            Console.WriteLine("\nChallenger of user\n");

            string permission = "Manager";
            int level = 1;

            if (permission.Contains("Admin") && level > 55)
                Console.WriteLine("Welcome, Super Admin user.");

            else if (permission.Contains("Admin") && level <= 55)
                Console.WriteLine("Welcome, Admin user.");

            else if (permission.Contains("Manager") && level >= 20)
                Console.WriteLine("Contact an Admin for access.");

            else if (permission.Contains("Manager") && level < 20)
                Console.WriteLine("You do not have sufficient privileges.");

            else
                Console.WriteLine("You do not have sufficient privileges.");


            Console.WriteLine("\nScope of variable\n");

            bool flag = true;
            int value = 0;

            if (flag)
            {
                value = 10;
                Console.WriteLine($"Inside of code block: " + value);
            }

            Console.WriteLine($"Outside of code block: {value}");

            string name = "steve";

            if (name == "bob")
                Console.WriteLine("Found Bob");

            else if (name == "steve")
                Console.WriteLine("Found Steve");

            
            else
                Console.WriteLine("Found Chuck");


            int[] numbers = { 4, 8, 15, 16, 23, 42 };
            int total = 0;
            bool found = false;

            foreach (int number in numbers)
            {
                total += number;

                if (number == 42)
                {
                    found = true;
                }
            }

            if (found)
                Console.WriteLine("Set contains 42");            

            Console.WriteLine($"Total: {total}\n");

            // implementando condição switch case

            int employeeLevel = 400;
            string employeeName = "John Smith";

            string title = "";

            switch (employeeLevel)
            {
                case 100:
                case 200:
                    title = "Senior Associate";
                    break;
                case 300:
                    title = "Manager";
                    break;
                case 400:
                    title = "Senior Manager";
                    break;
                default:
                    title = "Associate";
                    break;
            }

            Console.WriteLine($"{employeeName}, {title}");

            // SKU = Stock Keeping Unit. 
            // SKU value format: <product #>-<2-letter color code>-<size code>

            string sku = "01-MN-L";

            string[] product = sku.Split('-');

            string type = "";
            string color = "";
            string size = "";

            switch (product[0])
            {
                case "01":
                    type = "Sweat shirt";
                    break;

                case "02":
                    type = "T-Shirt";
                    break;

                case "03":
                    type = "Sweat pants";
                    break;

                default:
                    type = "Other";
                    break;
            }

            switch (product[1])
            {
                case "BL":
                    color = "Black";
                    break;

                case "MN":
                    color = "Maroon";
                    break;

                default:
                    color = "White";
                    break;
            }
            
            switch (product[2])
            {
                case "S":
                    size = "Small";
                    break;

                case "M":
                    size = "Medium";
                    break;

                case "L":
                    size = "Large";
                    break;

                default:
                    size = "One Size Fits All";
                    break;
            }
            
          
            Console.WriteLine($"Product: {size} {color} {type}\n");

            // Instruções função FOR
            // as tres partes do FOR - for (inicializador; conclusão; ação a ser executada a cada iteração) 

            string[] names = { "Alex", "Eddie", "David", "Michael" };

            //for (int i = 0; i < names.Length; i++)
            //{
            //    if (names[i] == "David")
            //    {
            //        names[i] = "Sammy";
            //    }
                    
            //}

            //foreach (var nami in names)
            //{
            //    Console.WriteLine(nami);
            //}
            
            // fizz buzz
            for (int i = 1; i < 20; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                    Console.WriteLine(i + " - FizzBuzz");

                else if (i % 5 == 0)
                    Console.WriteLine(i + " - Buzz");

                else if (i % 3 == 0)
                    Console.WriteLine(i + " - Fizz");

                else
                    Console.WriteLine(i);

            }

            Console.WriteLine("\nPress any key to close");
            Console.ReadKey();
        }
    }
}
