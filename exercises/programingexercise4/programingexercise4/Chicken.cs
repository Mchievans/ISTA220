using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programingexercise4
{
    public class Chicken
    {
        public int tagNumber;
        public string name1, name2, name3, name4;

        public Chicken()
        {
            name1 = "Rick the Rooster";
            name2 = "Rocky the Rooster";
            name3 = "Rip the Rooster";
            name4 = "Reign the Rooster";
        }

        public Chicken(int tagnumber)
        {
            tagNumber++;
        }

        public string Talk()
        {
            return ("COCKaDOODLEDOO");
        }

        public string Eat()
        {
            return ("Peck, Peck, Peck <<<<......");
        }
    }
}
