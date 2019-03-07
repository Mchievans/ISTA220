#region Using directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace StructsAndEnums
{
    class Program
    {
        static void doWork()
        {
            Month first = Month.december;
            Console.WriteLine(first);
            first++; 
            Console.WriteLine(first);// Cant assign month past dec so it prints 12

            Console.WriteLine();
            Date defaultDate = new Date();
            Console.WriteLine(defaultDate);

            Date birthday = new Date(1993, Month.february, 03);
            Console.WriteLine(birthday);

            Date copy = birthday;
            Console.WriteLine(copy); //prints day

            birthday.AdvanceMonth();
            Console.WriteLine($"1. {birthday}"); // prints the advancement 
            Console.WriteLine($"2. {copy}"); // prints copy of feb 

        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
