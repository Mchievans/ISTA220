using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programingexercise06
{
    public class March : Vehicle
    {
        public override void Pickup()
        {
            string howMany = "200 DeathTroopers";
            Console.WriteLine($"{howMany} Marched");
        }

        public override void Takeoff()
        {
            string start = "chit! chit! chit! chit!";
            Console.WriteLine($"Marching:{start}");
        }

        public override void Halt()
        {
            string stop = "post";
            Console.WriteLine($"Halting:{stop} !!!!");
        }
    }
}
