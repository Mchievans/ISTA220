using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programingexercise05
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = { 0, 2, 4, 6, 8, 10 };
            int[] B = { 1, 3, 5, 7, 9 };
            double[] C = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            Console.WriteLine($"There are {A.Length} numbers in Array A");
            getAvgA(A);
            Console.WriteLine($"There are {B.Length} numbers in Array B");
            getAvgB(B);
            Console.WriteLine($"There are {C.Length} numbers in Array C");
            getAvgC(C);
            Console.WriteLine();

            double averageA = Convert.ToDouble(getAvgA(A));
            double averageB = Convert.ToDouble(getAvgB(B));
            double averageC = Convert.ToDouble(getAvgC(C));

            Console.WriteLine($"The average of Array A is {averageA}");
            Console.WriteLine($"The average of Array B is {averageB}");
            Console.WriteLine($"The average of Array C is {averageC}");
            Console.WriteLine();

            getReverseA(A);
            Console.WriteLine();
            getReverseB(B);
            Console.WriteLine();
            getReverseC(C);
            Console.WriteLine();

            //print A Rotated Array
            Console.WriteLine();
            Console.WriteLine("Array A rotated two places left");
            int place = 2;
            moveArrayALeft(A, place);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Array B rotated two places right");
            int places = 3;
            moveArrayBRight(B, places);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Array C rotated four places left");
            double placesC = 4;
            moveArrayCLeft(C, placesC);
            Console.WriteLine();
            Console.WriteLine();

            sortArrayC(C);

        }

        private static void sortArrayC(double[] C)
        {
            double[] result = new double[C.Length];
            for (int i = 0; i < C.Length -2; i++)
            {
                for (int j = C.Length -1 ; j < C.Length + 1; j--)
                {
                    if (result[j] > result[i + 1])
                    {
                        double temp = result[i];
                        result[i] = result[j + 1];
                        result[i] = temp;
                        Console.Write($"{temp},");
                    }
                }
            }
        }

        private static void moveArrayCLeft(double[] C, double placesC)
        {
            double[] result = new double [C.Length];
            for (int i = 0; i < C.Length; i++)
            {
                result[i] = C[(i + 4) % C.Length];
                Console.Write($"{result[i]},");
            }
        }

        private static void moveArrayBRight(int [] B, int places)
        {
            int [] result = new int [B.Length];
            for (int i = 0; i < B.Length; i++)
            {
                result[i] = B[(i + places) % B.Length];
                Console.Write($"{result[i]},");
            }
        }

        private static void moveArrayALeft(int[] A, int place)
        {
            int[] result = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                result[i] = A[(i + 2) % A.Length];
                Console.Write($"{result[i]},");
            }
        }
        /* private static void ReverseArray(int[] arr)
         * {
         * int len = new A.length;
         * int [] rev new int [len]
         * for ( int i = o; j = len -1 ; i <len; i++, j--)
         *      {
         *      cw [j]
         *      }
         * } */

        private static void getReverseA(int[] A)
        {
            Console.WriteLine("The reverse of array A is:");
            for (int i = A.Length -1 ; i >= 0; i--)
            {
                Console.Write($"{A[i]},");
            }
            //for (int i = 0; j =len -1 ; i > 0; i--)
                //hold[i] = A[i]
        }

        private static void getReverseB(int[] B)
        {
            Console.WriteLine("The reverse of array B is:");
            for (int i = B.Length - 1; i >= 0; i--)
            {
                Console.Write($"{B[i]},");
            }
        }

        private static void getReverseC(double[] C)
        {
            Console.WriteLine("The reverse of array C is:");
            for (int i = C.Length - 1; i >= 0; i--)
            {
                Console.Write($"{C[i]},");
            }
        }

        private static int getAvgA(int[] a)
        {
            int countA = a.Length;
            int g = 0;
            for (int i = 0; i < countA; i++)
                {
                g += a[i];                
                }
            return g / countA;
        }

        private static int getAvgB(int[] b)
        {
            int countb = b.Length;
            int g = 0;
            for (int i = 0; i < countb; i++)
            {
                g += b[i];
            }
            return g / countb;
        }

        private static double getAvgC(double[] c)
        {
            double countc = c.Length;
            double g = 0;
            for (int i = 0; i < countc; i++)
            {
               g += c[i];
            }
            return Convert.ToDouble( g / countc);
        }
    }
}

