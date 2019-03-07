using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*double start = 2.0;
            double end = 10.0;
            double sumTen = 0.0;
            double ans = 0.0;
            sumTen = getAvgTen(start, end, sumTen);
            ans = calcAverage(sumTen);
            Get_letter_grade(ans);*/
            Console.WriteLine($"Total is {sumTen}");
        }

        private static double Get_letter_grade(double ans)
        {
            double letterGrade = 0.0;
            letterGrade = ans;
            Console.WriteLine($"The average Grade is: {letterGrade}");
            {
                if (letterGrade >= 90)
                    Console.WriteLine("A");
                else if ((letterGrade >= 80) && (letterGrade <= 89))
                    Console.WriteLine("B");
                else if ((letterGrade >= 70) && (letterGrade <= 79))
                    Console.WriteLine("C");
                else if ((letterGrade >= 60) && (letterGrade <= 69))
                    Console.WriteLine("D");
                else if (letterGrade < 60)
                    Console.WriteLine("F");
                return letterGrade;
            }
        }
        private static double calcAverage(double sumTen)
        {
            double average = sumTen / 10.0;
            return average;
        }
        private static double getAvgTen(double start, double end, double sumTen)
        {
            Console.WriteLine("Enter Grade:");
            double tenGrades = 0.0;
            tenGrades = Convert.ToDouble(Console.ReadLine());
            {
                if (start > end)
                    return sumTen + tenGrades;
                else
                    return getAvgTen(start + 1, end, sumTen) + tenGrades;                
            }
        }
    }
}
