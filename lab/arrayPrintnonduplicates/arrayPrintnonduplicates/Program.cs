using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayPrintnonduplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayA = { 1, 2, 2, 3, 4, 4, 5 };
            int[] hold = new int[arrayA.Length];
            int[] otherHold = new int[arrayA.Length];
            int len = arrayA.Length;
            valueArrayA(arrayA);
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (arrayA[i] == arrayA[j])
                    {
                            hold[i] = arrayA[i];                        
                            Console.Write($"{hold[i]},");
                    }
                    
                  for (int m = 0; m < len; m++)
                    {
                        
                    }
                } 
                
            }
            

        
        }

        private static void valueArrayA(int[] arrayA)
        {
            for (int i = 0; i < arrayA.Length; i++);
        }
    }
}
