﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        public class DVD
        {
            public string name;
            public int releaseYear;
            public string director;

            public DVD(String name, int releaseYear, string director)
            {
                this.name = name;
                this.releaseYear = releaseYear;
                this.director = director;
            }

            public string ToString()
            {
                return this.name + ", directed by " + this.director + ", release in " + this.releaseYear;
            }

        }


        static void Main(string[] args)
        {
            DVD[] dvdCollection = new DVD[15];
            
            DVD avengersDVD = new DVD("The Avengers", 2012, "Joss Whedon");

            dvdCollection[7] = avengersDVD;

            DVD incrediblesDVD = new DVD("The Incredibles", 2004, "Brad Bird");
            DVD findingDoryDVD = new DVD("Finding Dory", 2016, "Andrew Stanton");
            DVD lionKingDVD = new DVD("The Lion King", 2019, "Jon Favreau");

            // Put "The Incredibles" into the 4th place: index 3.
            dvdCollection[3] = incrediblesDVD;

            // Put "Finding Dory" into the 10th place: index 9.
            dvdCollection[9] = findingDoryDVD;

            // Put "The Lion King" into the 3rd place: index 2.
            dvdCollection[2] = lionKingDVD;

            DVD starWarsDVD = new DVD("Star Wars", 1977, "George Lucas");
            dvdCollection[3] = starWarsDVD;

            Console.WriteLine(dvdCollection[7].ToString());
            Console.WriteLine(dvdCollection[2].ToString());
            Console.WriteLine(dvdCollection[3].ToString());

            // Número quadrado é um número que ao extrair a raiz quadrada, o resultado é exato. 
            int[] squareNumbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                // We need to be careful with the 0-indexing. The next square number
                // is given by (i + 1) * (i + 1)
                // Calculate it and insert it into the Array at index i.
                int square = (i + 1) * (i + 1);
                squareNumbers[i] = square;

                // Console.WriteLine(squareNumbers[i]);
            }

            foreach (int square in squareNumbers)
            {
                Console.WriteLine(square);  
            }

            Console.ReadKey();

        }
    }
}
