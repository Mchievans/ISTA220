using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_reverse_print
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Malachi";            
            string reverse =  reverseString(name);
            string[] bust = name.Split(new char[] { ',' });
            foreach (string m in bust)
            {
                if (m != "")
                {
                    Console.WriteLine(m);
                }
            }
            Console.WriteLine($"{reverse}");

            Console.WriteLine();
            string pony = "my little pony";
            string reverse1 = reverseString(pony);
            string[] splitPony = pony.Split(' ');
            foreach (string m in splitPony)
            {
                if( m != "")
                {
                    Console.WriteLine(m);
                }
            }
            
            Console.WriteLine($"{reverse1}");

          
        }

        private static string reverseString(string n)
        {
            int len = n.Length;
            char[] r = new char[len]; 
            for (int i = 0, j = len - 1 ; i < len; i++, j--)
            {
                r[j] = n[i];
            }
            string s = new string(r);
            return (s);
        }
    }
}
