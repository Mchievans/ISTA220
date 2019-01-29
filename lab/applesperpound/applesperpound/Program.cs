using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace applesperpound
{
    class Program
    {
        
         static void Main(string[] args)
            {
                int pounds = getPounds();
                double pricePerpound = getPricePerPound();
                double totalPriceWithTax = getTaxPrice(intpounds, pricePerpound);
                printPrice();
            }

        private static double getTaxPrice(int v1, int pounds, double v2, Func<double> pricePerpound)
        {
            Console.WriteLine("enter take rate:");
            string strTax = Console.ReadLine();
            double dubTax = double.Parse(strTax);
            double totalprice = (pounds * pricePerpound);           
            return totalPriceWithTax = (totalprice * dubTax) + totalprice;            
        }

        private static double getPricePerPound()
        {
            Console.WriteLine("enter price per pound:");
            string pricePound = Console.ReadLine();
            double pricePerpound = double.Parse(pricePound);
            return pricePerpound;
        }

        private static int getPounds()
        {
            Console.WriteLine("Enter intger for pound:s");
            string strPounds = Console.ReadLine();
            int intpounds = int.Parse(strPounds);
            return intpounds; 
        }
    }
}
