using System;
using System.Collections.Generic;
using System.Linq;

namespace Week_1
{
    public class CoinsCharge
    {
        public static readonly int[] CoinsDenominations = new[] {25, 10, 5, 1};
        private Dictionary<int, int[]> _acc;

        public CoinsCharge()
        {
            _acc = new Dictionary<int, int[]>();
        }

        public int[] GetCoins(int sum, int[] coins)
        {
            for (int i = 0; i < CoinsDenominations.Length; i++)
            {
                var result = CalculateResult(sum, i, coins);
                _acc.Add(result.Sum(), result);
            }

            var min = _acc.Min(i => i.Key);
            return _acc[min];
        }

        private int[] CalculateResult(int sum, int currentIndex, int[] coins)
        {
            var result = new int[4];
            var remains = sum;
            for (int i = currentIndex; i < coins.Length; i++)
            {
                if (remains == 0)
                {
                    return result;
                }

                var coin = coins[i];
                var numberOfCoins = remains / coin;
                if (numberOfCoins > 0)
                {
                    result[i] = numberOfCoins;
                    remains -= coin * numberOfCoins;
                }
            }

            return result;
        }
    }
}