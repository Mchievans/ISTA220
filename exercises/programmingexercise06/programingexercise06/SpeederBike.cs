using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programingexercise06
{
    public class SpeederBike : Vehicle
    {
        public override void Pickup()
        {
            string howMany = "10 DeathTroopers";
            Console.WriteLine($"{howMany} mount Speader Bikes");
        }

        public override void Takeoff()
        {
            string start = "VROOM ! VROOM !";
            Console.WriteLine($"Taking Off: {start} !!!!");
        }

        public override void Halt()
        {
            string stop = "SKURTTTTT";
            Console.WriteLine($"Stoping: {stop} !!!!");
        }

    }
}
