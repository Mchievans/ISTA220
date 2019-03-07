using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integerassignment
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] x = new char[32];
            int purple = 16;
            int green = 16;
            Random r = new Random();
            for (int i = 0; i < x.Length; i++)
            {
                int m = r.Next() % 2;
                Console.WriteLine($"{m}");

                int checkG = 0;
                int checkP = 0;
                if (purple == checkP)
                {
                    m = 1;
                }
                else if (green == checkG)
                {
                    m = 0;
                }
                if (m == 0)
                {
                    x[i] = 'P';
                    purple--;
                }
                else if (m == 1)
                {
                    x[i] = 'G';
                    green--;
                }
            }
            foreach (char c in x)
                Console.Write(c);
        }
    }
}
