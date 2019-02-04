using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    public class square
    {
        private int side;

        public square(int side)
        {
            this.side = side; 
        }

        public double area(int side)
        {
            return (Math.Pow(side,2));
        }

        public int perimeter(int side)
        {
            return (side * 4);
        }
    }
}
