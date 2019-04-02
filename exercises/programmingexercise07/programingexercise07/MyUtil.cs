using System;


namespace programingexercise07
{
    public class MyUtil
    {
        public static int outcome = 0;
        //Evens or odds
        //public string RowOne = AddThreeFirst(outcome);
        //public static string RowTwo = AddThreeSecond(outcome);
        //public static string RowThree = AddThreeThird(outcome);

        public void EvenOdd(int outcome)
        {
            int remainder = 0;
            int oRemainder = 1;
            int check = outcome % 2;
            if (remainder == check)
            {
                Console.WriteLine("even");
            }
            else if (oRemainder == check)
            {
                Console.WriteLine("odd");
            }
        }

        //Reds or Blacks
        public void RedBlack(string bin)
        {
            if (bin == "black")
                Console.WriteLine("black");
            else if (bin == "green")
                Console.WriteLine("green");
            else
                Console.WriteLine("red");
        }

        //Lows or Highs
        public void LowHigh(int outcome)
        {
            if (outcome <= 18)
                Console.WriteLine("Lows");
            else
                Console.WriteLine("Highs");
        }

        //Dozens(Thirds)
        public void GetThirds(int outcome)
        {
            if (outcome >= 1 && 12 >= outcome)
                Console.WriteLine("1-12");
            else if (outcome >= 13 && 24 >= outcome)
                Console.WriteLine("13-24");
            else if (outcome >= 25 && 36 >= outcome)
                Console.WriteLine("25-36");
        }

        //Columns(first second third)
        public void GetColumns(int outcome)
        {
            int one = 1;
            int two = 2;
            int three = 3;
            string RowOne = AddThreeFirst(one);
            string RowTwo = AddThreeSecond(two);
            string RowThree = AddThreeThird(three);
            string[] rowSplit = RowOne.Split(',');
            string check = Convert.ToString(outcome);
            //Console.WriteLine(check);
            foreach (string checker in rowSplit)
            {
                if (check == checker)
                    Console.WriteLine(RowOne);
                else
                    continue;
            }

            string[] rowSplit2 = RowTwo.Split(',');
            string check2 = Convert.ToString(outcome);
            foreach (string checker in rowSplit2)
            {
                if (check2 == checker)
                    Console.WriteLine(RowTwo);
                else
                    continue;
            }

            string[] rowSplit3 = RowThree.Split(',');
            string check3 = Convert.ToString(outcome);
            foreach (string checker in rowSplit3)
                if (check3 == checker)
                    Console.WriteLine(RowThree);
                else
                    continue;
        }

        public string AddThreeFirst(int outcome)
        {
            //outcome = 1;
            string stroutcome = Convert.ToString(outcome + ",");
            //if (outcome == 1 || outcome == 2 || outcome == 3)
            {
                Console.Write(stroutcome);
                outcome = outcome + 3;
                if (outcome == 37)
                    return stroutcome;
                else if (outcome == 38)
                    return stroutcome;
                else if (outcome == 39)
                    return stroutcome;
                AddThreeFirst(outcome);
            }
            return stroutcome;
        }

        public string AddThreeSecond(int outcome)
        {

            string stroutcome = Convert.ToString(outcome + ",");
            Console.Write(stroutcome);
            outcome = outcome + 3;
            {
                if (outcome == 37)
                    return stroutcome;
                else if (outcome == 38)
                    return stroutcome;
                else if (outcome == 39)
                    return stroutcome;
                AddThreeSecond(outcome);
            }
            return stroutcome;
        }

        public string AddThreeThird(int outcome)
        {

            string stroutcome = Convert.ToString(outcome + ",");
            Console.Write(stroutcome);
            outcome = outcome + 3;
            {
                if (outcome == 37)
                    return stroutcome;
                else if (outcome == 38)
                    return stroutcome;
                else if (outcome == 39)
                    return stroutcome;
                AddThreeThird(outcome);
            }
            return stroutcome;
        }

        // ////Columns(street rows)
        ///public void StreetRows(int [] outcome)
        // {
        // //    if (outcome )


    }

}


