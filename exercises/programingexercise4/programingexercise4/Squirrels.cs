using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programingexercise4
{
    public class Squirrels
    {
        public string name1, name2, name3, name4;
        public int tagNumber;

        public Squirrels()
        {
            name1 = "Secret";
            name2 = "Conker";
            name3 = "Nutty";
            name4 = "Scrat";
        }

        public Squirrels(int tagnumber)
        {
            tagNumber++;
        }

        public string Talk()
        {
            return ("hide my nuts!");
        }

        public string Eat()
        {
            return ("tititititittititit");
        }
    }
}
