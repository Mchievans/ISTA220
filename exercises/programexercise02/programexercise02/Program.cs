using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programexercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1: Assign a Letter Grade");
            Console.WriteLine("Enter the Average Grade:");
            double answer = Convert.ToDouble(Console.ReadLine());
            get_Letter_Grade(answer);

            Console.WriteLine("\nPart 2: Return the Average of Ten Scores;");
            double start1 = -1.0;
            double end1 = 8.0;
            double sumTenGrades = 0.0;
            answer = avgTenScores(start1, end1, sumTenGrades);
            get_Letter_Grade(answer);

            Console.WriteLine("\nPart 3: Return the Average of a specific amount of Scores");
            Console.WriteLine("Enter the Amount of Scores:");
            double end2 = Convert.ToDouble(Console.ReadLine());
            double sumAmountGrades = 0.0;            
            answer = avgAmountGrades(start1,end2,sumAmountGrades);
            get_Letter_Grade(answer);

            Console.WriteLine("\nPart 4: Return the Average of a unspecified amount of Scores");
            Console.WriteLine("Enter a -1 at anytime to calculate the average:");            
            answer = avgUnkAmountGrades(start1, end2, sumAmountGrades);
            get_Letter_Grade(answer);

        }

        private static double avgUnkAmountGrades(double start1, double end2, double sumAmountGrades)
        {
            Console.WriteLine("Input grades:");
            double zero = 1.0;
            double counter = 1.0;
            //counter = counter + 1;
            counter = start1 + 1;
            zero = Convert.ToDouble(Console.ReadLine());
            sumAmountGrades = zero + sumAmountGrades;
            if (zero == -1.0)                
                return (sumAmountGrades / counter);
            else 
                return avgUnkAmountGrades(start1 + 1, end2, sumAmountGrades);
        }

        private static double avgAmountGrades(double start1, double end2, double sumAmountGrades)
        {            
            Console.WriteLine("Input grades:");
            double zero = 0.0;
            start1 = start1 +1;
            zero = Convert.ToDouble(Console.ReadLine());
            sumAmountGrades = zero + sumAmountGrades;
            if (start1 < end2)
                return avgAmountGrades(start1 + 1, end2, sumAmountGrades);
            else 
                return sumAmountGrades / end2;            
        }

        private static double avgTenScores(double start1, double end1, double sumTenGrades)
        {
            Console.WriteLine("Input Ten grades:");
            double zero = 0.0;            
            zero = Convert.ToDouble(Console.ReadLine());
            sumTenGrades = zero + sumTenGrades;
            if (start1 < end1)
                return avgTenScores(start1 + 1, end1, sumTenGrades);
            else
                //Console.WriteLine($"{sumTenGrades}");
                return sumTenGrades / 10.0; 
        }

        private static void get_Letter_Grade(double answer)
        {
            Console.WriteLine($"The average Grade is: {answer}");
            if (answer >= 90)
                Console.WriteLine("A");
            else if ((answer >= 80) && (answer <= 89))
                Console.WriteLine("B");
            else if ((answer >= 70) && (answer <= 79))
                Console.WriteLine("C");
            else if ((answer >= 60) && (answer <= 69))
                Console.WriteLine("D");
            if (answer < 60)
                Console.WriteLine("F");            
        }
    }
}
