using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programingexercise4
{
    public class NinjaTurtle
    {
        public string name1, name2, name3, name4;
        public int tagNumber;

        public NinjaTurtle()
        {
            name1 = "Leonardo";
            name2 = "Donatello";
            name3 = "Raphel";
            name4 = "Michaelango";
        }

        public NinjaTurtle(int tagnumber)
        {
            tagNumber++;
        }

        public string Talk()
        {
            return ("Cowabunga Dude!!!");
        }

        public string Eat()
        {
            return ("Pizza is Awesome sauce!");
        }
    }
}
