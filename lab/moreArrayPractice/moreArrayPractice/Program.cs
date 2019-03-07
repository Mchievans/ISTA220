using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 



namespace moreArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rando = new int[10];
            Random b = new Random();
            for(int i = 0; i < rando.Length; i++)
            {
                rando[i] = b.Next(200);
                Console.WriteLine(rando[i]);
            }

            int[] C = { -5, 10, -6, 4, 6, 1 };
            int[] D = new int [C.Length];
            getMaxm(C, D);
            //Console.WriteLine($"{getMaxm()}");

            Console.WriteLine();
            int max = max1(rando);
            int min = min1(rando);
            Console.WriteLine($"The largest value is {max}");
            Console.WriteLine($"The smallest value is {min}");
            Console.WriteLine();

            string t1 = "Dog";
            PrintAsciiVals(t1);

            string t2 = "abba";
            string t3 = "level";
            bool p = isPAL(t2);
            Console.WriteLine(p);
            p = isPAL(t3);
            //TEST Variable p = isPAL(t1);
            Console.WriteLine(p);

            string t4 = "Madam, I'm Adam";
            string t5 = "kjdkjndjk";
            bool P = PAL2(t4);
            bool l = PAL2(t5);
            Console.WriteLine(P);
            Console.WriteLine(l);

        }

        private static void getMaxm(int[] C, int[] D)
        {
            int h = C[0];
            for(int i = 0; i < C.Length-1; i++)
            {
                if(C[i] >= C[i + 1])
                {
                    D[i] = C[i];
                    h = D[i];
                    Console.WriteLine(h);
                }
            }
        }

        private static bool PAL2(string t4)
        {
            StringBuilder build = new StringBuilder();
            int[] hold = new int[t4.Length];
            for (int i = 0; i < t4.Length; i++)
            {
                hold[i] = (int)t4[i];
            }
            for (int j = 0; j < hold.Length; j++)
            {
                if (hold[j] > 64 && hold[j] < 91)
                    hold[j] += 32;
            }
            for (int m = 0; m < hold.Length; m++)
            {
                if (hold[m] > 96 && hold[m] < 122)
                    build.Append((char)hold[m]);
            }
            return isPAL(build.ToString());
        }

        private static bool isPAL(string t2)
        {
            for (int i = 0, j = t2.Length -1 ; i < t2.Length; i++, j--)
            { if ((int)t2[i] == (int)t2[j])
                    continue;
                else
                  return false;
            }
            return true; 
        }
                            
        private static int min1(int[] rando)
        {
            int min = rando[0];
            for (int i = 0; i < rando.Length; i++)
                if (rando[i] < min)
                    min = rando[i];
            return min;
        }

        private static void PrintAsciiVals(string t1)
        {
            for (int i = 0; i < t1.Length; i++)
                Console.WriteLine($"{(int)t1[i]}  ");
            Console.WriteLine();
        }

        private static int max1(int [] rando)
        {
            int max = rando[0];
            for( int i =0; i < rando.Length; i++)            
                if (rando [i] > max)                
                    max = rando[i];                    
            return max; 
        }
    }
}
