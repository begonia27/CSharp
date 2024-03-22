using System;

namespace Cards
{
    class PlayingCard
    {
        private readonly Suit _suit;
        private readonly Value _value;

        public PlayingCard(Suit s, Value v)
        {
            this._suit = s;
            this._value = v;
        }

        // 返回一张牌的字符串表示
        public override string ToString()
        {
            string result;
            string value;
            string suit;
            
            switch (_suit)
            {
                case Suit.Clubs:
                    suit = "♠";
                    break;
                case Suit.Diamonds:
                    suit = "♦";
                    break;
                case Suit.Hearts:
                    suit = "♥";
                    break;
                case Suit.Spades:
                    suit = "♣";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            switch (_value)
            {
                case Value.Two:
                    value = "2";
                    break;
                case Value.Three:
                    value = "3";
                    break;
                case Value.Four:
                    value = "4";
                    break;
                case Value.Five:
                    value = "5";
                    break;
                case Value.Six:
                    value = "6";
                    break;
                case Value.Seven:
                    value = "7";
                    break;
                case Value.Eight:
                    value = "8";
                    break;
                case Value.Nine:
                    value = "9";
                    break;
                case Value.Ten:
                    value = "10";
                    break;
                case Value.Jack:
                    value = "J";
                    break;
                case Value.Queen:
                    value = "Q";
                    break;
                case Value.King:
                    value = "K";
                    break;
                case Value.Ace:
                    value = "A";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
            result = $"{suit,-1}{value,2} ({_value,-5} of {_suit,-8})";

            return result;
        }

        public Suit CardSuit()
        {
            return this._suit;
        }

        public Value CardValue()
        {
            return this._value;
        }
    }
}
