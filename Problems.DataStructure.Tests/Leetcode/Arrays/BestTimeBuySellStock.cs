using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems.DataStructure.Tests.Leetcode.Arrays
{
    public static class BestTimeBuySellStock
    {
        public static int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length < 2)
                return 0;

            int minPrice = prices[0];
            int profit = 0;

            foreach (var price in prices)
            {
                if (price < minPrice)
                {
                    minPrice = price;
                }
                else
                {
                    int potentialProfit = price - minPrice;
                    profit = Math.Max(profit, potentialProfit);
                }
            }

            return profit;
        }
    }
}
