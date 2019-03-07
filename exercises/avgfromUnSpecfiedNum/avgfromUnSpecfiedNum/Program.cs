using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace avgfromUnSpecfiedNum
{
    class Program
    {
        static void Main(string[] args)
        {
            double start = 0.0;
            double end = 0.0;
            double grades = 0.0;
            double ans = 0.0;           
            double letter = 0.0;
            double num = 0.0;
            //end = inputend(end);            
            grades = getAvgGrades(start, end, grades, ans, letter, num);
            //double stop = end;
            //ans = calcAverage(grades, end, num);
            //num = divas(grades, num)
            letter = get_Letter_Grade(grades);
        }

        /*private static double divas(double grades, double num)
        {
           num = grades/ num;
            return num;
        }*/

        public static double get_Letter_Grade(double grades)
        {
                double letterGrade = 0.0;
                letterGrade = grades;
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
                    if (letterGrade < 60)
                        Console.WriteLine("F");
                    return letterGrade;
                }
        }

       private static double calcAverage(double grades, double end, double num)
        {
            
            double average = ( grades / end);
            return average;
        } 

        public static double getAvgGrades(double start, double end, double grades, double ans, double letter, double num)
        {
            Console.WriteLine("Enter Grade");
            Console.WriteLine($"Total number of Grades input {end}");
            Console.WriteLine($"Total number of Grades input {start}");
            //end = end + 1;            
            num = Convert.ToDouble(Console.ReadLine());
            end = -1.0;
            //double average = (grades / end);
            //ans = average;

            {
                if (grades != end)
                    {
                    double value = num;
                    return getAvgGrades(start + 1, ans, letter, num + value, grades, end);// + grades;
                }
                else 
                {
               //end = end + 1;
                return grades / start; //num = calcAverage(grades, end + 1) + end;
                                        }
                                       //return getAvgGrades(start, end, grades, ans, letter, num) + end;
            }

        }

        
    }
    }
