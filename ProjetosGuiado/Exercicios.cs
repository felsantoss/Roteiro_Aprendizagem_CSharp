using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosGuiado
{
    internal class Exercicios
    {
        static void Main(string[] args)
        {
            // initialize variables - graded assignments 
            int currentAssignments = 5;

            int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
            int[] andrewScore = new int[] { 92, 89, 81, 96, 90 };            
            int[] emmaScore = new int[] { 90, 85, 87, 98, 68 };
            int[] loganScore = new int[] { 90, 95, 87, 88, 96 };

            int sophiaSum = 0;
            
            decimal sophiaScore;

            foreach (int score in sophiaScores)
            {
                // add the exam score to the sum
                sophiaSum += score;
            }
                        
            sophiaScore = (decimal)sophiaSum / currentAssignments;
            
            Console.WriteLine("Student\t\tGrade\n");
            Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
            
            Console.WriteLine("Press the any key to continue");
            Console.ReadLine();

            
        }
    }
}
