using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_examples
{
    class Program
    {
        static void Main(string[] args)
        {
            Mammal m = new Mammal();
            m.Breathe();

            Horse h = new Horse();
            h.Breathe();
            h.Trot();
            h.Gallop();

            Whale w = new Whale();
            w.Breathe();
            w.Swim();
            w.Blow();

            m = h;
            m.Breathe();
            //m.Trot();

            //w = h;
            //w = m;

            Console.WriteLine(m.GetType()); 
            Console.WriteLine(h.GetType()); 
            Console.WriteLine(w.GetType()); 


        }
    }
}
