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
            double totalPriceWithTax = getTaxPrice(pounds, pricePerpound);
            printPrice(totalPriceWithTax);
        }

        private static void printPrice(double totalPriceWithTax) => 
            Console.WriteLine($"Your toatl price plus tax is {totalPriceWithTax}");
      

        private static double getTaxPrice(int pounds, double pricePerpound)
        {           
            Console.WriteLine("enter tax rate:");
            string strTax = Console.ReadLine();
            double dubTax = double.Parse(strTax);
            double totalprice = (pounds * pricePerpound);
            double totalPriceWithTax = (totalprice * dubTax) + totalprice;
            return totalPriceWithTax;
        }

        private static double getPricePerPound()
        {
            Console.WriteLine("enter price per pound:");ggh
            string pricePound = Console.ReadLine();
            double pricePerpound = double.Parse(pricePound);
            return pricePerpound;
        }

        private static int getPounds()
        {
            Console.WriteLine("Enter intger for pound:");
            string strPounds = Console.ReadLine();
            int intpounds = int.Parse(strPounds);
            return intpounds;
        }
    }
}
 