namespace Test08
{
     public struct Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

        public Time(int hh, int mm, int ss)
        {
            this._hours = hh / 24;
            this._minutes = mm / 60;
            this._seconds = ss / 60;
        }

        public Time(int hh, int mm)
        {
            this._hours = hh;
            this._minutes = mm;
            this._seconds = 0;
        }

        public int Hours()
        {
            return this._hours;
        }
        
        public int Minutes()
        {
            return this._minutes;
        }
        
        public int Seconds()
        {
            return this._seconds;
        }

        class Example
        {
            private Time currentTime;
        
            public void Method(Time parameter)
            {
                Time localVariable;
            }
        }

        // private Time? currentTime = null;
    }
}
