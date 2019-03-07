using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bananas
{
    class Program
    {
        static void Main(string[] args)
        {
            int pounds = getPounds();
            double pricePerpound() = getPricePerPound();
            double totalPriceWithTax = getTaxPrice( int lbs, double pricePerpound);
            printPrice();
        }
        private static double getPricePerPound()
        {
            Console.WriteLine("enter price per pound");
            string price = Console.ReadLine();
            double dprice = double.Parse(price);
            return double (pricePerpound);
        }

        private static int getPounds()
        {
            Console.WriteLine("Enter pounds of Bananas:");
            string pounds = Console.ReadLine();
            int lbs = int.Parse(pounds);
            return int(lbs);
        }
    }
}
