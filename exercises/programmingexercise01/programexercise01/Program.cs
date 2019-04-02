using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace programexercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPart 1 circumference " +
                    "and area of a circle.");
            Console.Write("Enter an intger for the radius:");        
            string strradius = Console.ReadLine();
            int intradius = int.Parse(strradius);
            double circumference = 2 * Math.PI * intradius;
            Console.WriteLine($"The circumference is {circumference}");
            double area = Math.PI * intradius * intradius;
            Console.WriteLine($"The area is {area}");

            Console.WriteLine("\nPart 2, volume of a hemisphere.");
            Console.Write("Enter an intger for the radius:");
            string strvolradius = Console.ReadLine();
            int intvolradius = int.Parse(strvolradius);
            double volume = 4.0 / 3.0 * Math.PI * (intvolradius * intvolradius * intvolradius) / 2.0;
            Console.WriteLine($"The volume is {volume}");

            Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");
            Console.WriteLine("Input intergers for the three sides of a triangle.");
            Console.WriteLine("Input side one of triangle.");
            string strsideone = Console.ReadLine();
            int intsideone = int.Parse(strsideone);
            Console.WriteLine("Input side two of triangle.");
            string strsidetwo = Console.ReadLine();
            int intsidetwo = int.Parse(strsidetwo);
            Console.WriteLine("Input side three of triangle.");
            string strsidethree = Console.ReadLine();
            int intsidethree = int.Parse(strsidethree);
            double semiperimeter = (intsideone + intsidetwo + intsidethree) / 2.0;
            double triarea = Math.Sqrt(semiperimeter * (semiperimeter - intsideone)
                * (semiperimeter - intsidetwo) * (semiperimeter - intsidethree));
            Console.WriteLine($"The area is {triarea}");

            Console.WriteLine("\nPart 4 solving a quadratic equation.");
            Console.WriteLine("Input intergers for the variables A, B, and C.");
            //Console.WriteLine("Use 2, 8, 6 as test numbers solution = -1, -3");//
            Console.WriteLine("Input variable A.");
            string strvara = Console.ReadLine();
            int intvara = int.Parse(strvara);
            Console.WriteLine("Input variable B.");
            string strvarb = Console.ReadLine();
            int intvarb = int.Parse(strvarb);
            Console.WriteLine("Input variable C.");
            string strvarc = Console.ReadLine();
            int intvarc = int.Parse(strvarc);
            double discriminate = Math.Pow(intvarb, 2.0) - (4.0 * intvara * intvarc);

            if (discriminate < 0)
            {
                Console.WriteLine("\nBoth soultions are not real numbers.");
            }
            double positivenum = -intvarb + Math.Sqrt(Math.Pow(intvarb, 2.0) - (4.0 * intvara * intvarc));
            double negativenum = -intvarb - Math.Sqrt(Math.Pow(intvarb, 2.0) - (4.0 * intvara * intvarc));
            double denominator = 2.0 * intvara;

            if (positivenum > 0)
            {
                Console.WriteLine($"The positive solution is {positivenum / denominator}");
            }
            else
            {
                Console.WriteLine($"The negative solution is {positivenum / denominator}");
            }

            if (negativenum > 0)
            {
                Console.WriteLine($"The positive solution is {negativenum / denominator}");
            }
            else
            {
                Console.WriteLine($"The negative solution is {negativenum / denominator}");
            }
        }

                








            
        }
    }

            
