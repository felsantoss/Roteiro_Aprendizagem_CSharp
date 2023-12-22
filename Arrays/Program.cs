using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        DVD[] dvdCollection = new DVD[15];

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

            public string toString()
            {
                return this.name + ", directed by " + this.director + ", release in " + this.releaseYear;
            }
        }

        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
