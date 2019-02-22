using System;

namespace StructsAndEnums
{
    struct Date
    {
        private int year;
        private Month month; // Month type (enum) Enum case sensitive
        private int day;

        public Date(int ccyy, Month mm, int dd)
        {
            this.year = ccyy - 1900;
            this.month = mm;
            this.day = dd - 1; // day is 0
        } // default is jan 01 1900 until you assign numbers

        public override string ToString()
        {           
            string data = $"{this.month} {this.day + 1}," 
            + $"{ this.year + 1900}";
            return data; //day + 1 because computers are 0 based 
            
        }

        public void AdvanceMonth()
        {
            this.month++; // adds one to month
            if (this.month == Month.december + 1) //if month equal to 12
            {
                this.month = Month.january;//then make month equal 0
                this.year++;// add one to year 
            }
        }
    }
}
