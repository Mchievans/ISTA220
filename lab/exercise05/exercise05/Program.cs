using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] C = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            getAvg(C);
        }

        private static double [] getAvg(double [] C)
        {
            double countc = C.Length;
            double g = 0;
            for (double i = 0; i < countc; i++)
            {
                double m = C[i];
                g += m;
            }
            return g /countc
        }
    }
}
