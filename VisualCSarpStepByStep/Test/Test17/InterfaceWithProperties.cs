namespace Test17
{
    interface IScreenPosition
    {
        int CC { get; set; }
        int DD { get; set; }
    }
    
    class OtherScreenPosition : IScreenPosition
    {
        private int _a;
        private int _b;
    
        public virtual int CC
        {
            get => this._a;
            set
            {
                var i = this._a;
            }
        }

        public virtual int DD
        {
            get => this._b;
            set
            {
                var n = this._b;
            }
        }

        public OtherScreenPosition(int height, int width)
        {
            this._a = height * height;
            this._b = width * width;
        }
    }

    struct ScreenPositionPrevious : IScreenPosition
    {
        private int n;
        private int m;
        
        int IScreenPosition.CC
        {
            get => this.n;
            set
            {
                var i = this.n;
            }
        }

        int IScreenPosition.DD
        {
            get => this.m;
            set
            {
                var i = this.m;
            }
        }

        public ScreenPositionPrevious(int firstValue, int secondValue)
        {
            this.n = (int)Math.Pow(firstValue, 3);
            this.m = (int)Math.Pow(secondValue, 2);
        }
    }
}
