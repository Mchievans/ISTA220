using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programingexercise06
{
    public class BlasterRifle : Weapons
    {
        public override void Shoot()
        {
            string type = "E-11 blaster rifle";
            string sound = "Doot, Doot, Doot";
            Console.WriteLine($"Using {type}: {sound}!!!");
        }

        public override void Reload()
        {
            int rounds = 30;
            Console.WriteLine($"{rounds} rounds loaded");
        }
    }
}
