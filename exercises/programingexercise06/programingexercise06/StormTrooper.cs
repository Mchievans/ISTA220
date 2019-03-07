using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programingexercise06
{
    public class StormTrooper :Trooper
    {
        public override void SoundOff()
        {
            string type = "StormTroopers";
            Console.WriteLine($"{type} are the keenest weapon in the Emperor's arsenal..");
        }

        public override void OrderofBattle()
        {
            string unit = "company";
            Console.WriteLine($"you employed a {unit} of StormTroopers.");
        }
    }
}
