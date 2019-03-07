using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programingexercise4
{
    public class BigDogs
    {
        public string name1, name2, name3, name4;
        public int tagNumber;

        public BigDogs()
        {
            name1 = "Scooby Doo";
            name2 = "Beethoven";
            name3 = "Hooch";
            name4 = "Clifford";
        }

        public BigDogs(int tagnumber)
        {
            tagNumber++;
        }

        public string Talk()
        {
            return ("Roof Roof!!");
        }

        public string Eat()
        {
            return ("chew, chew, chew");
        }
    }
}
