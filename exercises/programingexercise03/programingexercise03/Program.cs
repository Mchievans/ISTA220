using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programingexercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPart 1 circumference and area of a circle.");
            Console.Write("Enter an interger for the radius:");
            int intradius = 0;
            var circumference = circum(intradius);       
            Console.WriteLine($"The circumference is {circumference}");
            double area = areaCircle(circumference);
            Console.WriteLine($"The area is {area}");

            Console.WriteLine("\nPart 2, volume of a hemisphere.");
            Console.Write("Enter an interger for the radius:");
            int hemisphereRadius = 0;
            double volume = hemisphereVolume(hemisphereRadius);
            Console.WriteLine($"The volume is {volume}");

            Console.WriteLine("\nPart 3, area of a triangle (Heron's formula).");
            Console.WriteLine("Input intergers for the three sides of a triangle.");            
            int intsideone = 0;
            int intsidetwo = 0;
            int intsidethree = 0;
            double triangleArea = triangleFormula(intsideone, intsidetwo, intsidethree);
            Console.WriteLine($"The area is {triangleArea}");

            Console.WriteLine("\nPart 4 solving a quadratic equation.");
            Console.WriteLine("Input intergers for the variables A, B, and C.");
            int intVariableA = 0;
            int intVariableB = 0;
            int intVariableC = 0;
            double discriminate = findDiscriminate(intVariableA, intVariableB, intVariableC);
     
        
    }

        private static double findDiscriminate(int intVariableA, int intVariableB, int intVariableC)
        {
            try
            {
                Console.WriteLine("Input variable A.");
                string strVariableA = Console.ReadLine();
                intVariableA = int.Parse(strVariableA);
                Console.WriteLine("Input variable B.");
                string strVariableB = Console.ReadLine();
                intVariableB = int.Parse(strVariableB);
                Console.WriteLine("Input variable C.");
                string strVariableC = Console.ReadLine();
                intVariableC = int.Parse(strVariableC);
                double discriminate = Math.Pow(intVariableB, 2.0) - (4.0 * intVariableA * intVariableC);
                if (discriminate < 0)
                {
                    Console.WriteLine("\nBoth soultions are not real numbers.");
                }
                double positivenum = -intVariableB + Math.Sqrt(Math.Pow(intVariableB, 2.0) - (4.0 * intVariableA * intVariableC));
                double negativenum = -intVariableB - Math.Sqrt(Math.Pow(intVariableB, 2.0) - (4.0 * intVariableA * intVariableC));
                double denominator = 2.0 * intVariableA;

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
            catch (FormatException)
            {
                Console.WriteLine("Inputs invalid, You must enter valid numbers");
                return findDiscriminate(intVariableA, intVariableB, intVariableC);
            }
            finally
            {
                Console.WriteLine("Your numbers are okay.");
            }
        return findDiscriminate(intVariableA, intVariableB, intVariableC);
        }

        private static double triangleFormula(int intsideone, int intsidetwo, int intsidethree)
        {
            try
            {
                Console.WriteLine("Input side one of triangle.");
                double semiperimeter = 0.0;
                string strsideone = Console.ReadLine();
                intsideone = int.Parse(strsideone);
                Console.WriteLine("Input side two of triangle.");
                string strsidetwo = Console.ReadLine();
                intsidetwo = int.Parse(strsidetwo);
                Console.WriteLine("Input side three of triangle.");
                string strsidethree = Console.ReadLine();
                intsidethree = int.Parse(strsidethree);
                if (intsideone > 0)
                {
                    if (intsidetwo > 0)
                        if (intsidethree > 0)
                            semiperimeter = (intsideone + intsidetwo + intsidethree) / 2.0;
                    double triAngleArea = Math.Sqrt(semiperimeter * (semiperimeter - intsideone)
                * (semiperimeter - intsidetwo) * (semiperimeter - intsidethree));
                    return triAngleArea;
                }
                else if (intsideone <= 0)
                {
                    if (intsidetwo <= 0)
                        if (intsidethree <= 0)
                            Console.WriteLine("Inputs are out of range");                    
                    return triangleFormula(intsideone, intsidetwo, intsidethree);
                }               
                else if (strsideone != "")
                {
                    if (strsidetwo != "")
                        if (strsidethree != "")
                    Console.WriteLine("Inputs invalid, You must enter valid numbers");                                      
                    return triangleFormula(intsideone, intsidetwo, intsidethree);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Input invalid, You must enter a valid number");                
                return triangleFormula(intsideone, intsidetwo, intsidethree);
            }
            finally
            {
                if (intsideone > 0)
                {
                    if (intsidetwo > 0)
                        if (intsidethree > 0)
                            Console.WriteLine("Your numbers are okay.");
                }
            }
            return triangleFormula(intsideone, intsidetwo, intsidethree);
        
        }

        private static double hemisphereVolume(int hemisphereRadius)
        {
            try
            {
                string strVolRadius = Console.ReadLine();
                hemisphereRadius = int.Parse(strVolRadius);
                if (hemisphereRadius > 0)
                {
                    double volume = 4.0 / 3.0 * Math.PI * (hemisphereRadius * hemisphereRadius * hemisphereRadius) / 2.0;
                    return volume;
                }
                else if (hemisphereRadius <= 0)
                {
                    Console.WriteLine("Input is out of range"); ;
                    Console.Write("Enter an interger for the radius:");
                    return hemisphereVolume(hemisphereRadius);
                }
                else if (strVolRadius != " ")
                {
                    Console.WriteLine("Input invalid, You must enter a valid number");
                    Console.Write("Enter an interger for the radius:");
                    strVolRadius = Console.ReadLine();
                    hemisphereRadius = int.Parse(strVolRadius);
                    return hemisphereRadius;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Input invalid, You must enter a valid number");
                Console.Write("Enter an intger for the radius:");
                return hemisphereVolume(hemisphereRadius);
            }
            finally
            {
                if (hemisphereRadius > 0)
                {
                    Console.WriteLine("Your number is okay.");
                }
            }
            return hemisphereVolume(hemisphereRadius);
        }

        private static double areaCircle(double circumference)
        {
           double radius = circumference / Math.PI / 2;
            double area = Math.PI * radius * radius;
            return area;
        }

        private static double circum(int intradius)
        {
           try
            {
                string strradius = Console.ReadLine();
                intradius = int.Parse(strradius);
                if (intradius > 0)
                {                    
                    double circumference = 2 * Math.PI * intradius;
                    return circumference;
                }
                else if (intradius <= 0)
                {
                    Console.WriteLine("Input is out of range");                    ;
                    Console.Write("Enter an interger for the radius:");
                    return circum(intradius);
                }
                else if (strradius != " ")
                {
                    Console.WriteLine("Input invalid, You must enter a valid number");
                    Console.Write("Enter an interger for the radius:");
                    strradius = Console.ReadLine();
                    intradius = int.Parse(strradius);
                    return intradius;
                }
            }            
            catch (FormatException)
            {              
                Console.WriteLine("Input invalid, You must enter a valid number");
                Console.Write("Enter an interger for the radius:");
                return circum(intradius);
            }
            finally
            {
                if (intradius > 0)
                {
                    Console.WriteLine("Your number is okay.");
                }
            }
            return circum(intradius);
       }
    }
}

