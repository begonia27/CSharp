using System;
using System.Runtime.InteropServices.JavaScript;

namespace StructsAndEnums
{
    // class Date
    struct Date
    {
        private int _year;
        private Month _month;
        private int _day;

        public Date(int ccyy, Month mm, int dd)
        {
            this._year = ccyy - 1900;
            this._month = mm;
            this._day = dd - 1;
        }

        public override string ToString()
        {
            string data = $"{this._month} {this._day + 1} {this._year + 1900}";
            return data;
        }

        public void AdvanceMonth()
        {
            this._month++;
            if (this._month == Month.December + 1)
            {
                this._month = Month.January;
                this._year++;
            }
        }
    }
}
