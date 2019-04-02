using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programingexercise06
{
    public class HeavyBlasterRifle : Weapons
    {
        public override void Shoot()
        {
            string type = "DLT-19D heavy blaster rifle";
            string sound = "Pow, Pow, Pow";
            Console.WriteLine($"Using {type}: {sound}!!!");
        }

        public override void Reload()
        {
            int rounds = 10;
            Console.WriteLine($"{rounds} rounds loaded");
        }
    }
}
