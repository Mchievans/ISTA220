using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenMoreArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 4, 6, 7, 8, 9 };
            int V = 5;
            int [] b = new int [a.Length + 1];
            insert5(a, V, b);
            Console.WriteLine();
            //PrintArray(a);
            //PrintArray(a);

            int[] c = new int [] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] d = new int [c.Length - 1];
            drop5(c, d, V);

            
            //PrintArray();
            //bool checkon = false;            
            //insertVinArray(a, b, V);
            //Console.WriteLine(b);
            //foreach (int vic in b
            //Console.WriteLine(string.Join("", a));
            
            //Console.WriteLine($"{insertVinArray(a, b, V)}");
        }

        private static void drop5(int[] c, int[] d, int V)
        {
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == V)
                    d[i] = c[i + 1];
                else if (c[i] < V)
                    d[i] = c[i];
                else
                    d[i - 1] = c[i];
            }    
            PrintArray(d);
        }

        private static void PrintArray(int [] a )
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"{a[i]}");
            }             
        }


        private static void insert5(int[] a, int V, int[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {   if (a[i] < V)
                {
                    b[i] = a[i];

                }
                else if (V > a[i] && a[i + 1] > V)
                {
                    i = V;
                    //a[i] = V;
                    b[i] = a[i + 1];
                }
                else if (V < a[i])

                    b[i] = a[i];
                
             

            }
            
            PrintArray(b);


        }
    }
}
