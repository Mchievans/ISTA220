#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Classes
{
    public class Point
    {
        private int x;
        private int y;
        private static int objectCount = 0;

        public Point()
        {
            Console.WriteLine("Default Constructor called");
            this.x = -1;
            this.y = -1;
            objectCount++;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            Console.WriteLine($"x:{x}, y:{y}");
            objectCount++;
        }

        public double DistanceTo(Point other)
        {
            //double distance2 = first.DistanceTo(second);
            // first takes the place of this.
            // second takes the place of other
            int xDiff = this.x - other.x;
            int yDiff = this.y - other.y;
            double distance = Math.Sqrt((xDiff * xDiff) + (yDiff * yDiff));
            return distance;
        }

        public void ToString()
        {
            Console.WriteLine($"x is {this.x}, y is {this.y}");
        }

        public static int ObjectCount() => objectCount;
    }
}
