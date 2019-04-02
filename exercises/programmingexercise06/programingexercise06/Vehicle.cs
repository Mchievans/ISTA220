using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programingexercise06
{
   public class Vehicle
    {
        public virtual void Pickup()
        {
            string howMany = "10 troops";
            Console.WriteLine($"you picked up {howMany}");
        }

        public virtual void Takeoff()
        {
            string start = "noise";
            Console.WriteLine($"{start} !!!!");
        }

        public virtual void Halt()
        {
            string stop = "noise";
            Console.WriteLine($"{stop} !!!!");
        }
    }
}
