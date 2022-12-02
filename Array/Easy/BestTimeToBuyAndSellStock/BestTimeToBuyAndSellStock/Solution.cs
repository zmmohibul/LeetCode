using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestTimeToBuyAndSellStock
{
    public class Solution
    {
        public static int MaxProfit(int[] prices)
        {
            int max = 0;
            int i = 0;
            for (int j = 1; j < prices.Length; j++)
            {
                if (prices[j] < prices[i])
                {
                    i = j;
                }
                else
                {
                    max = Math.Max(max, prices[j] - prices[i]);
                }
            }

            return max;
        }
    }
}
