using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programingexercise06
{
    public class DeathTrooper : Trooper
    {
        public override void SoundOff()
        {
            string type = "DeathTroopers";
            Console.WriteLine($"{type} at your service.");
        }

        public override void OrderofBattle()
        {
            string unit = "squad";
            Console.WriteLine($"you employed a {unit} of DeathTroopers.");
        }
    }
}
