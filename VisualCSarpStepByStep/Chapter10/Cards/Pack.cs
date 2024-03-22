using System;

namespace Cards
{
    class Pack
    {
        // 4 种花色
        private const int NumSuits = 4;
        
        // 每个花色有 13 张点数
        private const int CardsPerSuit = 13;
        
        // 二维数组：第一维是花色，第二维是点数
        private readonly PlayingCard[,] _cardPack;
        
        // 洗牌（调用随机数生成器 Next 方法）
        private readonly Random _randomCardSelector = new Random();

        /*
         * 一整副排好序的牌，外层循环是每种花色，内层循环是每种点数
         * 每张牌都是一个二维数组，由花色和点数构成
         * 每张牌都需要重新 new 出一个值，这个值就是循环的最小单位
         */
        public Pack()
        {
            this._cardPack = new PlayingCard[NumSuits, CardsPerSuit];

            /*
             * 循环的初始化表示式：花色枚举中的第一个值
             * 循环的控制语句：花色枚举中的最后一个值
             */
            for (Suit suit = Suit.Clubs; suit <= Suit.Spades; suit++)
            {
                /*
                 * 循环的初始化表达式：点数枚举中的第一个值
                 * 循环的控制语句：点数枚举中的最后一个值
                 */
                for (Value value = Value.Two; value <= Value.Ace; value++)
                {
                    /*
                     * 数组的索引只能使用整数值
                     * 花色和点数是枚举类型的值，可以转换成整型的值
                     */
                    this._cardPack[(int)suit, (int)value] = new PlayingCard(suit, value);
                }
            }
        }

        /*
         * 随机选一张牌，然后从这副牌中将该牌移除并返回这张牌
         * 先从花色中随机
         * 再从该花色的点数中随机
         */
        public PlayingCard DealCardFromPack()
        {
            // 随机找一个花色
            Suit suit = (Suit)_randomCardSelector.Next(NumSuits);
            
            // 如果找不到该花色，就找下一个花色
            while (this.IsSuitEmpty(suit))
            {
                suit = (Suit)_randomCardSelector.Next(NumSuits);
            }

            // 随机找一个点数
            Value value = (Value)_randomCardSelector.Next(CardsPerSuit);
            
            // 根据上一个循环中找到的花色，再找该花色中的下一个点数
            while (this.IsCardAlreadyDealt(suit, value))
            {
                value = (Value)_randomCardSelector.Next(CardsPerSuit);
            }
            
            /*
             * 当找到这张牌之后，就在牌堆里把这张牌设置为空（避免下一次随机到），然后返回这张牌
             */
            PlayingCard card = this._cardPack[(int)suit, (int)value];
            this._cardPack[(int)suit, (int)value] = null;
            return card;
        }

        // 是否找到指定花色和点数的牌
        private bool IsSuitEmpty(Suit suit)
        {
            /*
             * 如果指定的花色不在牌堆里，返回结果 true
             * 这样就能进行下一个牌的花色随机了
             * 调用 Next 方法，执行下一个花色的随机循环
             */
            bool result = true;
            
            for (Value value = Value.Two; value <= Value.Ace; value++)
            {
                // 如果该点数的牌不为空，那么就返回 false
                // if (!(this._cardPack[(int)suit, (int)value] == null))
                if (!IsCardAlreadyDealt(suit, value))
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        /*
         * 返回一个布尔值，比较该花色的牌是否为空
         */
        private bool IsCardAlreadyDealt(Suit suit, Value value)
            // => (this._cardPack[(int)suit, (int)value] == null);
        {
            return this._cardPack[(int)suit, (int)value] == null;
        }
    }
}
