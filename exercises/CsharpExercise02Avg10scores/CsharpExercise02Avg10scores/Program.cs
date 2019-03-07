using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpExercise02Avg10scores
{
    class Program
    {
        static void Main(string[] args)
        {          
            int start = 1;
            int end = 9;
            double sum = 0.0;            
            //double numgrade = 1.0;
            double numGrades = 0.0;
            sum = getSumOfSquares(start, end, numGrades, sum);
            double ans = calcAverage(sum);            
            Console.WriteLine($"The average grade is {ans} ");
        }

        public static double getSumOfSquares(double start, double end, double numGrade, double sum)
        {
            Console.WriteLine($"Input Ten Grades:{start}");            
            //string strNumGrade = Console.ReadLine();
            // double numGrades = double.Parse(strNumGrade);
            double numGrades = Convert.ToDouble(Console.ReadLine()); 
            //double numGrade = + numGrades;
            Console.WriteLine($"Calling getSumOfSquares({numGrades}");

            if (start > end)
                return (sum);
            else               
                return getSumOfSquares(start + 1, end, numGrade + numGrades, sum);
        }
        public static double calcAverage(double sum)
        {
            double average = sum / 10.0;
            return average;
        }

        /*private static double get_avg_ten_scores()
        {
            Console.WriteLine("Input ten test scores in either an integer, float, or double format:");
            string strNumGrade1 = Console.ReadLine();
            double numGrade = double.Parse(strNumGrade);*/
    }
    }



