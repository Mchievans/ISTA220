using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    public class Circle
    {
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public double Area(int radius)
        {
            return (Math.PI * Math.Pow(radius,2)); 
        }

        public double Circum(int radius)
        {
            return (2 * Math.PI * radius);
        }
    }
}
