using System;

namespace Cards
{
    // 将所选的牌添加到一手牌中
    class Hand
    {
        public const int HandSize = 13;
        private PlayingCard[] _cards = new PlayingCard[HandSize];
        private int _playingCardCount = 0;
        
        public void AddCardToHand(PlayingCard cardDealt)
        {
            if (this._playingCardCount >= HandSize)
            {
                throw new ArgumentException("Too many cards");
            }

            this._cards[this._playingCardCount] = cardDealt;
            this._playingCardCount++;
        }

        // 生成手上所有牌的字符串表示
        public override string ToString()
        {
            string result = "";
            foreach (PlayingCard card in this._cards)
            {
                result += $"{card.ToString()}{Environment.NewLine}";
            }

            return result;
        }
    }
}
