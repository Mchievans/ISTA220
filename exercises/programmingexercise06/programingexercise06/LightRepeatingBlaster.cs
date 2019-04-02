using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programingexercise06
{
   public class LightRepeatingBlaster : Weapons
    {
        public override void Shoot()
        {
            string type = "SE-14r light repeating blaster";
            string sound = "Pew !, Pew";
            Console.WriteLine($"Using {type}: {sound}!!!");
        }

        public override void Reload()
        {
            int rounds = 15;
            Console.WriteLine($"{rounds} rounds loaded");
        }
    }
}
