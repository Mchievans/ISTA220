using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programingexercise06
{
    public class JumpTrooper : Trooper
    {
        public override void SoundOff()
        {
            string type = "JumpTroopers";
            Console.WriteLine($"{type} Jet Packs on, Ready to fly.");
        }

        public override void OrderofBattle()
        {
            string unit = "platoon";
            Console.WriteLine($"you employed a {unit} of JumpTroopers.");
        }
    }
}
