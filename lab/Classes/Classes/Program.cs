using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void doWork()
        {
            Point origin = new Point();
            Point origin1 = new Point(2,3);
            Point bottomRight = new Point(1366, 768);
            Point first = new Point(0, 0);
            Point second = new Point(4, 3);
            first.ToString();
            second.ToString();

            double distance2 = first.DistanceTo(second);
            Console.WriteLine($"Distance2 is {distance2}");
            double distance = origin.DistanceTo(bottomRight);
            Console.WriteLine($"Distance is: {distance}");
            Console.WriteLine($"Number of Point objects: {Point.ObjectCount()}");
            double distance3 = second.DistanceTo(first);
            Console.WriteLine($"Distance3 is {distance3}");

        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
