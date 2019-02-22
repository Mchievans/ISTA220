using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraypractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] amy = { 3, 10, 15, 7, 2, 3, 7, 2, 10, 10 };
            int[] hold = new int[amy.Length];
            PrintArray(amy);
            for(int i = 0; i < amy.Length; i++)
            {
                int match = amy[i];
                //if (seenbefore(match, hold)) continue;
                for (int k = 0; k < hold.Length; k++)
                {
                    //Console.WriteLine($"{match} -- {hold[k]}");
                    if (match == hold[k]) break;
                }
                int count = 1;
                for(int j = i + 1; j < amy.Length; j++)
                {
                    if (match == amy[j])
                    {
                        count++;
                        hold[i] = match;
                    }
                }
               // PrintArray(hold);
                Console.WriteLine($"{match} has {count} duplicates");

            }
        }


        private static void PrintArray(int[] amy)
        {
            for(int i =0; i < amy.Length; i++)
            {
                Console.Write($"{amy[i]}  ");
            }
            Console.WriteLine();
        }
    }
}
