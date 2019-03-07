using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //sum the square of numbers 1 to 10
            Console.WriteLine("Sum the sqaure of numbers from 1 to 10");
            int start = 1;
            int end = 10;
            int acc = 0;
            double sum = 0.0;
            acc = getSumOfSquares(start, end, acc);
            Console.WriteLine("The sum of squares is acc:");

            Console.WriteLine("Sum the cubes of numbers 1 to 10");
            acc = getSumOfCubes(start, end, acc);
            Console.WriteLine("The sum of cubes is {acc}");

            Console.WriteLine("Sum the squareroots of numbers 1 to 10");
            sum = getSumSqrt(start, end, sum);
            Console.WriteLine("The sum of squareroots is {sum}");

        }

        private static double getSumSqrt(int start, int end, double sum)
        {
            Console.WriteLine($"Calling getSumSqrt ({start},{end},{sum})");
            if (start > end)
                return (sum);
            else
                return getSumSqrt(start + 1, end, + Math.Sqrt(sum));
        }

        private static int getSumOfCubes(int start, int end, int acc)
        {
            Console.WriteLine($"Calling getSum of cubes ( {start},{end},{acc})");
            if (start > end)
                return (acc);
            else
                return getSumOfCubes(start + 1, end, + start * start * start);
           

        }

        private static int getSumOfSquares(int start, int end, int acc)
        {
            Console.WriteLine($"Calling getSum of squares( {start},{end},{acc})");
            if (start > end)
                return (acc);
            else
                return getSumOfSquares(start + 1, end, + start * start);
        }
    }
}
