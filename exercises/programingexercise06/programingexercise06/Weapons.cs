using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programingexercise06
{
    public class Weapons
    {
        public virtual void Shoot()
        {
            string type = "blaster";
            string sound = "noise";
            Console.WriteLine($"Using {type}: {sound}!!!");
        }

        public virtual void Reload()
        {
            int rounds = 30;
            Console.WriteLine($"{rounds} rounds loaded");
        }

    }
}
