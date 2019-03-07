using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an input as radius");
            string strrad = Console.ReadLine();
            int intrad = Int32.Parse(strrad);
            Circle circle = new Circle(intrad);
            double area = circle.Area(intrad);
            Console.WriteLine($" The area is {area}");
            double circum = circle.Circum(intrad);
            Console.WriteLine($"The circumference is {circum}");

            Console.Write("Enter an input as side");
            string strside = Console.ReadLine();
            int intside = Int32.Parse(strside);
            square s = new square(3);
            area = s.area(intside);
            Console.WriteLine($" The area is {area}");
            double p = s.perimeter(intside);
            Console.WriteLine($"The circumference is {p}");
        }
    }
}
