using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programingexercise06
{
    public class JetPacks : Vehicle
    {
        public override void Pickup()
        {
            string howMany = "50 JumpTroopers";
            Console.WriteLine($"you commanded {howMany} to fly");
        }

        public override void Takeoff()
        {
            string start = "pshhhhhtttt!!";
            Console.WriteLine($"Flying: {start} {start}!!!!");
        }

        public override void Halt()
        {
            string stop = "plop";
            Console.WriteLine($"Landing: {stop} !");
        }
    }
}
