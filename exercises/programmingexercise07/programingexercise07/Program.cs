using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace programingexercise07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberBin = new int[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17,
                18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37};

            int[] numberBox = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17,
                18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37 };

            string[] colorBin = new string[] { "green", "red", "black", "red", "black",
                "red", "black", "red", "black", "red", "black", "black", "red", "black",
                "red", "black", "red", "black", "red", "red",
                "black", "red", "black", "red", "black", "red", "black", "red",
                "black", "black", "red", "black", "red", "black", "red", "black", "red", "green" };

            Console.WriteLine("Place your Bets");

            Console.WriteLine("Press any key to spin wheel.");
            Console.ReadKey();
            Console.WriteLine();

            //SECTION TO PLACE BETS

            //OUTCOME BLOCK
            MyUtil useUtil = new MyUtil();

            //Number FROM BIN
            Console.WriteLine("The wheel landed on");
            Random rand = new Random();

            int numberRolled = rand.Next(numberBin.Length);

            //string color = colorBin[numberbin];

            Console.WriteLine($"{numberBin[numberRolled]}");
            Console.WriteLine($"{colorBin[numberRolled]}");
            Console.WriteLine();

            foreach (int number in numberBin)
            {
                Console.WriteLine();
                string color = colorBin[number];
                Console.WriteLine("The possible wining combinations for:" + number);
                //j = numberbin[number];
                //EVENS OR ODDS
                useUtil.EvenOdd(number);
                //REDS OR BLACKS
                useUtil.RedBlack(color);
                //LOWS OR HIGHS
                useUtil.LowHigh(number);
                //DOZENS(ROW THIRDS)
                useUtil.GetThirds(number);
                //Columns(first second third)
                if (number == 1)
                    useUtil.AddThreeFirst(number);
                else if (number == 2)
                    useUtil.AddThreeSecond(number);
                else if (number == 3)
                    useUtil.AddThreeThird(number);
                else if (number == 0)
                    continue;
                else
                    useUtil.GetColumns(number);
                
            }
            
        }
    }
}

