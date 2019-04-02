using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programingexercise06
{
    public class Trooper
    {       
        public virtual void SoundOff()
        {
            string type = "trooper";
            Console.WriteLine($"I am a {type}");
        }

        public virtual void OrderofBattle()
        {
            string unit = "squad, platoon, company, battalion";
            Console.WriteLine($"you employed a {unit} of troopers");
        }

        
        
         
    }
}
