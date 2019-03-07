using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaryOperators
{
    class Program
    {
        static void Main(string[] args)
        {   
            //INVERSES ONES AND ZEROS
            short notop = ~204;
            Console.WriteLine($"not operator is {notop}");

            //SHFT BY ONE IT DOUBLES(SHIFT BY TWO AND IT QUADROUPLES) SO ON AND SO FOURTH 
            short lsop = 204 << 2;
            Console.WriteLine($"left shift {lsop}");

            // TAKES BINARY OF BOTH PLACES OVER EACH OTHER (TRUE FALSE FOR EACH DIGIT PLACE
            //TO FIND ANSWER ONE AND ONE EQUALS ONE/ ONE AND ZERO EQUALS ONE )
            short orop = 204 | 24;
            Console.WriteLine($"not operator is {orop}");

            //TAKES BINARY OF BOTH PLACES OVER EACH OTHER (TRUE FALSE FOR EACH DIGIT PLACE AND
            //TO FIND ANSWER ONE AND ONE EQUALS ONE/ ONE AND ZERO EQUALS zERO )
            short andop = 204 & 24;
            Console.WriteLine($"not operator is {andop}");

            //TAKES BINARY OF BOTH PLACES OVER EACH OTHER 
            //(TRUE FOR ONE AND ZERO AND ZERO OF ONE AND ONE OR ZERO AND ZERO)
            short xorop = 204 ^ 24;
            Console.WriteLine($"not operator is {xorop}");
        }
    }
}
