using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_examples
{
    public static class MyUtil
    {
        public static Horse Gallop(this Horse h)
        {
            Console.WriteLine("This horse gallops");
            return h;
        }

        public static Whale Blow(this Whale w)
        {
            Console.WriteLine("This is a Whale blowing");
                return w;
        }
    }
}
