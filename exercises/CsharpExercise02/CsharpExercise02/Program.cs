using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            get_letter_grade();
        }

        private static void get_letter_grade()
        {
            Console.WriteLine("Input either an integer, float, or double for grade:");
            string strNumGrade = Console.ReadLine();
            double numGrade = double.Parse(strNumGrade);
            {
                if (numGrade >= 90)
                    Console.WriteLine("A");
                else if (numGrade >= 80)
                {
                    Console.WriteLine("B");
                }
                else if (numGrade >= 70)
                {
                    Console.WriteLine("C");
                }
                else if (numGrade >= 60)
                {
                    Console.WriteLine("D");
                }
                else if (numGrade < 60)
                {
                    Console.WriteLine("F");
                }
                

            }
        }
    }
}
