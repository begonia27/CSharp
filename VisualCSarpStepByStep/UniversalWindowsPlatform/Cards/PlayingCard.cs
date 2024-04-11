namespace Cards
{
    class PlayingCard
    {
        private readonly Suit suit;
        private readonly Value value;

        public PlayingCard(Suit s, Value v)
        {
            suit = s;
            value = v;
        }

        public override string ToString()
        {
            string result = string.Format("{0} of {1}", value, suit);
            return result;
        }

        public Suit CardSuit
        {
            get
            {
                return suit;
            }
        }

        public Value CardValue
        {
            get
            {
                return value;
            }
        }
    }
}
